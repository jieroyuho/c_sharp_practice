using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList02
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.AddFirst(3);
            a.AddLast(2);
            a.AddLast(1);
            a.ShowAllNode();

            a.PopFirst();
            a.ShowAllNode();

            a.PopLast();
            a.ShowAllNode();

            a.PopLast();
            a.ShowAllNode();


            LinkedList b = new LinkedList();
            b.AddFirst(3);
            b.AddLast(2);
            b.AddLast(1);
            b.ShowAllNode();

            b.PopFirst();
            b.ShowAllNode();

            b.PopLast();
            b.ShowAllNode();

            b.PopLast();
            b.ShowAllNode();
            Console.ReadLine();


        }


    }


}
