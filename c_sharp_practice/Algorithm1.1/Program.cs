using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxPairwiseProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Console.Read();          
            // 不要用Read()在使用者輸入，因為會讀到空白，換行
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = int.Parse(input1);

            var input = Console.ReadLine().Split(' ');

            //Version 1        
            //int[] num = Array.ConvertAll(input, s => int.Parse(s));
            //long[] num = Array.ConvertAll(input, long.Parse);

            //Version 2
            //var num = input.Select(s => int.Parse(s));
            List<long> numlist = new List<long>();
            numlist.AddRange(input.Select(s => long.Parse(s)));


            Console.WriteLine(MaxPair(numlist));
            Console.ReadLine();
        }

        private static long MaxPair(List<long> num)
        {
            long MaxNum = long.MinValue;
            long Max2 = long.MinValue;
            //MaxNum = num.OrderByDescending(r => r).FirstOrDefault();
            //Max2 = num.OrderByDescending(r => r).Take(2).LastOrDefault();
            //Console.WriteLine(MaxNum);
            //Console.WriteLine(Max2);
           
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] >= MaxNum)
                {
                    Max2 = MaxNum;
                    MaxNum = num[i];
                }
                else if (num[i] > Max2)
                {
                    Max2 = num[i];
                }
            }
            return MaxNum * Max2;

        }
    }
}