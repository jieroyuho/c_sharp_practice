using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = @".\tests\" + String.Format("{0:00}", 22);

            string t1 = System.IO.File.ReadAllText(s1);

            string Delimiter = "\r\n";
            var t1SplitRN = t1.Split(new[] { Delimiter }, StringSplitOptions.None);


            var inputFirstLine = t1SplitRN[0].Split(' ');

            int bufferSize = Int32.Parse(inputFirstLine[0]);
            int packNumber = Int32.Parse(inputFirstLine[1]);

            List<Pack> inputList = new List<Pack>();

            for (int j = 1; j <= packNumber; j++)
            {
                var packInput = t1SplitRN[j].Split(' ');
                Pack thepack = new Pack(Int32.Parse(packInput[0]), Int32.Parse(packInput[1]), j - 1);
                inputList.Add(thepack);
            }

            TimeProcess.Process(bufferSize, inputList);

            //var inputFirstLine = Console.ReadLine().Split(' ');

            //int bufferSize = Int32.Parse(inputFirstLine[0]);
            //int packNumber = Int32.Parse(inputFirstLine[1]);

            //List<Pack> inputList = new List<Pack>();

            //for (int i = 0; i < packNumber; i++)
            //{
            //    var packInput = Console.ReadLine().Split(' ');

            //    Pack thepack = new Pack(Int32.Parse(packInput[0]), Int32.Parse(packInput[1]), i);
            //    inputList.Add(thepack);
            //}

            ////PacketProcess.Process(bufferSize, inputList);
            //TimeProcess.Process(bufferSize, inputList);
            Console.ReadLine();
        }

    }

    public static class PacketProcess
    {
        public static void Process(int bufferSize, List<Pack> SeqInput)
        {
            int ListSize = SeqInput.Count;

            if (ListSize == 0)
            {
                return;
            }

            MyQueue<Pack> myQueue = new MyQueue<Pack>(bufferSize);
            int[] outputList = new int[ListSize];

            int BeginTime = SeqInput[0].ArriveTime;
            int LastArriveTime = SeqInput[ListSize - 1].ArriveTime;

            int current = BeginTime;

            for (int i = 0; i < ListSize; i++)
            {
                int NextArriveTime = SeqInput[i].ArriveTime;

                //  清空上一輪在Queue的值
                if (NextArriveTime > current)
                {
                    QueueProcessing(ref outputList, ref myQueue, current, NextArriveTime);

                    current = NextArriveTime;

                }

                //假若進來的第一個，Queue是空的，且Process Time 是零，則馬上出去。
                if (myQueue.IsEmpty() == true && SeqInput[i].ProcessTime == 0)
                {
                    outputList[i] = SeqInput[i].ArriveTime;
                    break;
                }

                // 同一時間抵達的進Queue，若Queue已滿，則寫入-1
                if (myQueue.Enqueue(SeqInput[i]) == -1)
                {
                    outputList[i] = -1;
                }


                // 最後一輪，全部處理
                if (i == ListSize - 1 && myQueue.IsEmpty() == false)
                {
                    QueueProcessing(ref outputList, ref myQueue, current, 100000000);
                }


            }

            for (int i = 0; i < outputList.Length; i++)
            {
                Console.WriteLine("{0}", outputList[i]);
            }

        }

        private static void QueueProcessing(ref int[] outputList, ref MyQueue<Pack> myQueue, int startTime, int endTime)
        {
            for (int t = startTime; t < endTime; t++)
            {
                if (myQueue.Count == 0)
                {
                    return;
                }

                Pack current = myQueue.TopFirst();

                // 如果處理時間=0，馬上丟出，並馬上抓下一個來看
                if (current.ProcessTime == 0)
                {
                    outputList[current.ID] = t;
                    myQueue.Dequeue();
                    current = myQueue.TopFirst();
                }

                //同一時間到達的就存入Queue的處理

                // 查看這時間點，這個系統是否已執行:
                // 如果是，則Begin Time 是固定的，
                // 如果否，則Begin Time 設定Arrive Time + 處理完前一個的時間
                if (current.isProcessing == false)
                {
                    current.isProcessing = true;
                    current.BeginTime = t;
                }

                current.ProcessTime = current.ProcessTime - 1;
                myQueue.TopModify(current);

                if (current.ProcessTime == 0)
                {
                    outputList[current.ID] = current.BeginTime;
                    myQueue.Dequeue();
                }





            }
        }



    }

    public static class TimeProcess
    {
        public static void Process(int bufferSize, List<Pack> SeqInput)
        {
            int ListSize = SeqInput.Count;

            if (ListSize == 0)
            {
                return;
            }
            MyQueue<Pack> myQueue = new MyQueue<Pack>(bufferSize);
            int[] outputList = new int[ListSize];
            int i = 0;

            Pack FinalInput = SeqInput[ListSize - 1];
            int finalTime = Int32.MaxValue - 1; // MaxValue will cause overflow

            for (int t = 0; t <= finalTime; t++)
            {
                if (i < ListSize)
                {
                    while (SeqInput[i].ArriveTime <= t)
                    {
                        if (myQueue.IsEmpty() && SeqInput[i].ProcessTime == 0)
                        {
                            outputList[i] = SeqInput[i].ArriveTime;
                        }
                        else if (myQueue.Enqueue(SeqInput[i]) == -1)
                        {
                            outputList[i] = -1;
                        }

                        i++;

                        if (i >= ListSize)
                        {
                            break;
                        }
                    }
                    QueueProcessing(ref outputList, ref myQueue, t, t + 1);

                }

                else
                {
                    QueueProcessing(ref outputList, ref myQueue, t, finalTime);
                    t = finalTime;
                }

            }
            for (int j = 0; j < outputList.Length; j++)
            {
                Console.WriteLine("{0}", outputList[j]);
            }
        }


        private static void QueueProcessing(ref int[] outputList, ref MyQueue<Pack> myQueue, int startTime, int endTime)
        {
            for (int t = startTime; t < endTime; t++)
            {
                if (myQueue.Count == 0)
                {
                    t = endTime;
                    return;
                }

                Pack current = myQueue.TopFirst();

                // 如果處理時間=0，馬上丟出，並馬上抓下一個來看
                if (current.ProcessTime == 0)
                {
                    outputList[current.ID] = t;
                    myQueue.Dequeue();
                    current = myQueue.TopFirst();
                }

                //同一時間到達的就存入Queue的處理

                // 查看這時間點，這個系統是否已執行:
                // 如果是，則Begin Time 是固定的，
                // 如果否，則Begin Time 設定Arrive Time + 處理完前一個的時間
                if (current.isProcessing == false)
                {
                    current.isProcessing = true;
                    current.BeginTime = t;
                }

                current.ProcessTime = current.ProcessTime - 1;
                myQueue.TopModify(current);

                if (current.ProcessTime == 0)
                {
                    outputList[current.ID] = current.BeginTime;
                    myQueue.Dequeue();
                }





            }
        }



    }


    public struct Pack
    {
        public int ArriveTime;
        public int ProcessTime;
        public int ID;
        public int BeginTime;
        public bool isProcessing;
        public Pack(int aTime, int pTime, int id)
        {
            this.ArriveTime = aTime;
            this.ProcessTime = pTime;
            this.ID = id;
            this.BeginTime = 0;
            this.isProcessing = false;
        }

    }

}
