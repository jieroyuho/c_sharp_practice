using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm2._1
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fibonacci_small(n));
            //Console.WriteLine(fibonacci_rec (n));
            Console.ReadLine();

        }

        static int fibonacci_small(int n)
        {
            if (n <= 1)
                return n;

            int[] fab = new int[n+1];
            fab[0] = 0;
            fab[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fab[i] = fab[i - 1] + fab[i - 2];
            }

            return fab[n];
        }


        static int fibonacci_rec(int n)
        {
            if (n <= 1)
                return n;

            int result = fibonacci_rec(n - 1) + fibonacci_rec(n - 2);
            return result;
        }

    }
}
