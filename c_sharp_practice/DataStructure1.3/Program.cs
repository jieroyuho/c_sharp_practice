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
            var inputFirstLine = Console.ReadLine().Split(' ');

            int bufferSize = Int32.Parse(inputFirstLine[0]);
            int packNumber = Int32.Parse(inputFirstLine[1]);

            List<Pack> inputList = new List<Pack>();

            for (int i = 0; i < packNumber; i++)
            {
                var packInput = Console.ReadLine().Split(' ');

                Pack thepack = new Pack( Int32.Parse(packInput[0]), Int32.Parse(packInput[1]));
                inputList.Add(thepack);
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                Console.WriteLine("{0}", inputList[i].ArriveTime);
            }

            Queue<int> myQueue = new Queue<int>(2);


            PacketProcess.Process(bufferSize, inputList);


            Console.ReadLine();
        }

    }

    public static class PacketProcess
    {
        public static void Process(int bufferSize, List<Pack> SeqInput)
        {
            int ListSize = SeqInput.Count;
            MyQueue<Pack> myQueue = new MyQueue<Pack>(bufferSize);
            List<int> outputList = new List<int>(ListSize);

            int BeginTime = 0;
            int LastArriveTime = SeqInput[ListSize - 1].ArriveTime;
            
            int current = BeginTime;

            for (int i = 0; i < ListSize; i++)
            {
                int NextArriveTime = SeqInput[i].ArriveTime;

                if (NextArriveTime > current)
                {
                    int processTime = NextArriveTime - current;
                    QueueProcessing(ref myQueue, processTime);

                    current = NextArriveTime;

                }
                

                if (myQueue.Enqueue(SeqInput[i]) == -1)
                {
                    outputList[i] = -1;
                }
                else
                {
                    outputList[i] = SeqInput[0].ArriveTime;
                }
            }

        }

        private static void QueueProcessing(ref MyQueue<Pack> myQueue,  int processTime)
        {
            for (int i = 0; i < myQueue.Count; i++)
            {
                Pack current = myQueue.Dequeue();

                current.ArriveTime = current.ArriveTime - processTime;

                myQueue.Enqueue(current);
            }
        }
        
            

    }

    public struct Pack
    {
        public int ArriveTime;
        public int ProcessTime;
        public Pack(int aTime, int pTime)
        {
            this.ArriveTime = aTime;
            this.ProcessTime = pTime;
        }

    }

}
