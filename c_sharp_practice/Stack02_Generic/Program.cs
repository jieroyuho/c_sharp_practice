using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack02_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Point> a = new Stack<Point>();

            Point a1 = new Point(1, 2);
            Point a2 = new Point(3, 4);
            Point a3 = new Point(5, 6);
            Point a4 = new Point(7, 8);

            a.Push(a1);
            a.Push(a2);
            a.Push(a3);
            a.Push(a4);

            //a.ShowStack();
            showIndexPoint(a, 3);

            a.Pop();
            showIndexPoint(a, 3);

            //Point x = a.PopLast();
            //showPoint(x);

            //x = a.PopFirst();
            //showPoint(x);

            Console.ReadLine();


        }
        public static void showPoint(Point a)
        {
            Console.WriteLine("The Point's X = {0}, Y = {1}", a.x, a.y);
        }

        public static void showIndexPoint(Stack<Point> llt, int index)
        {
            Point a;
            for (int i = 0; i <= index; i++)
            {
                a = llt.TopByIndex(i);
                Console.WriteLine("The Point[{0}]: X = {1}, Y = {2}", i, a.x, a.y);
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
}
