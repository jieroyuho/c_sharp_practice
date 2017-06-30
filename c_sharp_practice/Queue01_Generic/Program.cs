using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> q = new MyQueue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            q.Dequeue();

            showAll(q, 3);

            //q.ShowQueue();

            Console.ReadLine();

        }

        public static void showAll(MyQueue<int> a, int index)
        {

            for (int i = 0; i <= index; i++)
            {
                int q = a.TopByIndex(i);
                Console.WriteLine("Index[{0}]: {1} ", i, q);
            }
        }
    }
}
