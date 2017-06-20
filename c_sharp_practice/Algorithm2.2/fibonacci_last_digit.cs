using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm2._2
{
    class fibonacci_last_digit
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fibonacci_last(n));
            Console.ReadLine();

        }

        static int fibonacci_last(int n)
        {
            if (n <= 1)
                return n;

            int temp_1 = 1;  // fab[1]
            int temp_2 = 0;  // fab[0]

            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = temp_1 + temp_2;
                //result = result % 10;
                temp_2 = temp_1 % 10;
                temp_1 = result % 10;

            }

            return result%10;
        }

    }
}
