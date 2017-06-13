using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List01
{
    class Program
    {
        static void Main(string[] args)
        {

            string source = "12 21 3 42 25 36 47 18 29 30";

            //Method 1 : use ToList()
            var numbers = source.Split(' ').Select(s => int.Parse(s)).ToList();
            //var numbets = source.Split(' ').Select(Int32.Parse).ToList();
            Console.WriteLine("Show Method 1 with sorted list");
            numbers.Sort();
            foreach (int x in numbers)
            {
                //Console.WriteLine(x);
                Console.Write("{0} ", x);
            }
         

            //Method 2 : use List.AddRange
            string[] input = source.Split(' ');
            var lst = new List<int>();
            lst.AddRange(input.Select(s => int.Parse(s)));
            ////lst.AddRange(input.Select(int.Parse));
            Console.WriteLine("\n\nShow Method 2 with unsorted list");
            foreach (int x in lst)
            {
                Console.Write("{0} ", x);
            }

            Console.WriteLine("\nAfter Method 2 sorted");
            lst.Sort();
            foreach (int x in lst)
            {
                //Console.WriteLine(x);
                Console.Write("{0} ", x);
            }

            Console.ReadLine();
        }

    }
}
