using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    public interface IMachine
    {
        void Start();
        void Stop();
        string color { get; set; }
    }
}
