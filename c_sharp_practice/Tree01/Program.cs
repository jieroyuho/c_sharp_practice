using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree01
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node() { value = 1 };
            Node c1 = new Node() { value = 2 };
            Node c2 = new Node() { value = 3 };

            root.AddChild(c1);
            c1.AddChild(c2);
           
            Console.WriteLine("{0}", root.GetNodeHeight() );
            Console.WriteLine("{0}", c1.GetNodeHeight() );
            Console.WriteLine("{0}", c2.GetNodeHeight() );

            Console.ReadLine();
        }

    }
}
