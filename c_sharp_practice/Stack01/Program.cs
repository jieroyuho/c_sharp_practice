using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack();

            showEmpty(a.IsEmpty());

            _excutePush(a, 1);
            _excutePush(a, 3);
            _excutePush(a, 5);
            _excutePush(a, 7);
            _excutePush(a, 9);
            _excutePush(a, 11);
            a.ShowStack();

            _excutePop(a.Pop());
            showTop(a.Top());
            showTop(a.Top());
            _excutePop(a.Pop());

            a.ShowStack();

            Console.ReadLine();
        }

        static void _excutePush(Stack a, int key)
        {
            a.Push(key);

            Console.WriteLine("Push : {0}", key);
        }

        static void _excutePop(int? pop)
        {
            if (pop == null)
                Console.WriteLine("This stack is empty");
            else
                Console.WriteLine("Pop : {0}", pop);
        }


        static void showTop(int? top)
        {
            if (top == null)
                Console.WriteLine("This stack is empty");
            else
                Console.WriteLine("Top : {0}", top);
        }

        static void showEmpty(bool check)
        {
            if (check)
                Console.WriteLine("This stack is empty");
            else
                Console.WriteLine("This stack is not empty");
        }
    }
}
