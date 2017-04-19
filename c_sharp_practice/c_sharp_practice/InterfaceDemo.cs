using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class InterfaceDemo
    {
        public void RunDemo1()
        {
            Car c = new c_sharp_practice.Car();
            IMachine c2 = new c_sharp_practice.Car();
            IMachine b = new c_sharp_practice.Bike();
            c.Start();
            // c.Stop(); 使用explicit interface 可以讓物件找不到
            c2.Stop();

            b.Start();
            b.Stop();
        }


        public void RunDemo2()
        {
            IMachine c = new c_sharp_practice.Car();
            IMachine b = new c_sharp_practice.Bike();
            Start(c);
            Stop(c);
            Start(b);
            Stop(b);

        }

        private void Start(IMachine m)
        {
            m.Start();
        }
        private void Stop(IMachine m)
        {
            m.Stop();
        }
        public void RunDemo3()
        {
            Car c = new c_sharp_practice.Car();
            Bike b = new c_sharp_practice.Bike();

            IMachine ic = (IMachine)c;
            IMachine ib = (IMachine)b;

            Start(ic);
            Stop(ic);
            Start(ib);
            Stop(ib);

        }

        public void RunDemo4()
        {
            Car c = new c_sharp_practice.Car();
            c.color = "blue";
            IMachine ic = (IMachine)c;
            // 以下的例子說明這是by reference

            System.Console.WriteLine("This Car's color is {0}\n",c.color);
            System.Console.WriteLine("This ICar's color is {0}\n", ic.color);
            ic.color = "red";
            System.Console.WriteLine("(After change interface) This Car's color is {0}\n", c.color);
            //ic.color = "red";
            System.Console.WriteLine("(After change interface) This ICar's color is {0}\n", ic.color);

            ic.color = "yellow";
            System.Console.WriteLine("(After change class) This Car's color is {0}\n", c.color);
            //ic.color = "red";
            System.Console.WriteLine("(After change class) This ICar's color is {0}\n", ic.color);
        }
    }
}
