using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm2._3
{
    class gcd
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int x = Int32.Parse(input[0]);
            int y = Int32.Parse(input[1]);

            Console.WriteLine(gcds(x, y));
            Console.ReadLine();
        }

        static int gcds(int x, int y)
        {
            // Euclidean algorithm
            swapToMaxOnFirst(ref x, ref y);
            int remainder = y;
            int divider = 1;

            while (remainder != 0)
            {
                divider = x / y;
                remainder = x % y;
                if (remainder == 0)
                    return y;
                x = x - y*divider;
                swapToMaxOnFirst(ref x, ref y);

            }

            return 0;
        }

        static void swapToMaxOnFirst(ref int max, ref int second)
        {
            int tmp;
            if (second > max)
            {
                tmp = max;
                max = second;
                second = tmp;
            }

        }


    }
}
