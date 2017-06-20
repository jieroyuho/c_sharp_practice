using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms2._4
{
    class lcm
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int x = Int32.Parse(input[0]);
            int y = Int32.Parse(input[1]);

            int NumGCD = gcdCal(x, y);

            // Num1 x Num2 = Greatest Common Divisor (GCD) x Least Common Multiple

            int NumLCM = (x / NumGCD) * y;

            Console.WriteLine(NumLCM);
            Console.ReadLine();
        }

        static int gcdCal(int x, int y)
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
                x = x - y * divider;
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
