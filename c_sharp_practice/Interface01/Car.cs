using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class Car : IMachine
    {
        // 沒有加 public會錯
        public string color { get; set;}
        // This is explicit implementation
        void IMachine.Start()
        {
            System.Console.WriteLine("This Car Starts");
        }

        // This is implicit implementation
        public void Start()
        {
            System.Console.WriteLine("This Car Starts");
        }

        void IMachine.Stop()
        {
            System.Console.WriteLine("This Car Ends");
        }

        //public void Stops()
        //{
        //    System.Console.WriteLine("This Car Ends");
        //}



    }
}
