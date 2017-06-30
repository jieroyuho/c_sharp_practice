using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList03_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListTail<Point> a = new LinkedListTail<Point>();

            Point a1 = new Point(1, 2);
            Point a2 = new Point(3, 4);
            Point a3 = new Point(5, 6);
            Point a4 = new Point(7, 8);

            a.AddFirst(a1);
            a.AddFirst(a2);
            a.AddFirst(a3);
            a.AddFirst(a4);

            a.ShowAllNode();
            showIndexPoint(a, 5);

            Point x = a.PopLast();
            showPoint(x);

            x = a.PopFirst();
            showPoint(x);
            //a.ShowAllNode();
            //a.PopLast();
            //a.PopLast();
            //a.ShowAllNode();
            ////a.PopLast();
            //a.ShowAllNode();

            Console.ReadLine();
        }
        public static void showPoint(Point a)
        {
            Console.WriteLine("The Point's X = {0}, Y = {1}", a.x, a.y);
        }

        public static void showIndexPoint(LinkedListTail<Point> llt, int index)
        {
            Point a;
            for (int i = 0; i <= index; i++)
            {
                a = llt.GetByIndex(i);
                Console.WriteLine("The Point[{0}]: X = {1}, Y = {2}", i, a.x, a.y);
            }
        }

    }
}
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }


