using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList01
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList sll = new SingleLinkedList();

            sll.AddLast(1);
            sll.AddLast(2);
            sll.AddLast(3);
            sll.AddFirst(4);
            sll.AddFirst(5);
            sll.AddLast(6);
            sll.AddFirst(2);
            sll.AddFirst(3);
            sll.AddLast(1);
            sll.AddFirst(1);
            sll.AddFirst(1);
            sll.ShowAllNode();

            //sll.PopFirst();
            //sll.PopLast();
            //sll.PopLast();
            //sll.ShowAllNode();

            sll.RemoveKey(4);
            sll.ShowAllNode();

            sll.RemoveAllKey(3);
            sll.ShowAllNode();

            sll.RemoveAllKey(1);
            sll.ShowAllNode();
            //Console.WriteLine();


            Console.ReadLine();
        }
    }
}
