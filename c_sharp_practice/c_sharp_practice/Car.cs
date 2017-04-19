using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class Car : IMachine
    {
        void IMachine.Start()
        {
            System.Console.WriteLine("This Car Starts");
        }

        void IMachine.Stop()
        {
            System.Console.WriteLine("This Car Ends");
        }

    }
}
