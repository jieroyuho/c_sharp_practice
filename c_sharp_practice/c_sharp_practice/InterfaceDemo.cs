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
            IMachine c = new c_sharp_practice.Car();
            IMachine b = new c_sharp_practice.Bike();

            c.Start();
            c.Stop();
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
    }
}
