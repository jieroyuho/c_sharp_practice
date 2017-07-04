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

            Console.WriteLine("------------------------------");

            MyQueue2<int> q2 = new MyQueue2<int>(3);

            q2.Enqueue(1);
            q2.Enqueue(2);
            q2.Enqueue(3);
            q2.Enqueue(4);
            q2.Enqueue(5);

            q2.Dequeue();

            showAll2(q2, q2.Count);

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

        public static void showAll2(MyQueue2<int> a, int index)
        {

            for (int i = 0; i < index; i++)
            {
                int q = a.TopByIndex(i);
                Console.WriteLine("Index[{0}]: {1} ", i, q);
            }
        }
    }
}
