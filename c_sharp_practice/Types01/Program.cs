using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using IsPrimitive to check Primitive

            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(int).Name, typeof(int).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(Int32).Name, typeof(Int32).IsPrimitive);

            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(double).Name, typeof(double).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(float).Name, typeof(float).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(bool).Name, typeof(bool).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(byte).Name, typeof(byte).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(char).Name, typeof(char).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(Char).Name, typeof(Char).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(decimal).Name, typeof(decimal).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(string).Name, typeof(string).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(String).Name, typeof(String).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(DateTime).Name, typeof(DateTime).IsPrimitive);
            Console.WriteLine("The {0} type of Primitive is {1}.", typeof(Etype).Name, typeof(Etype).IsPrimitive);
            //Console.WriteLine("The {0} type of Primitive is {1}.", typeof(enum).Name, typeof(enum).IsPrimitive);
            Console.WriteLine("\n");

            Console.WriteLine("The {0} type of Value Type is {1}.", typeof(Int32).Name, typeof(Int32).IsValueType);
            Console.WriteLine("The {0} type of Value Type is {1}.", typeof(string).Name, typeof(string).IsValueType);
            Console.WriteLine("The {0} type of Value Type is {1}.", typeof(Ctype).Name, typeof(Ctype).IsValueType);
            Console.WriteLine("The {0} type of Value Type is {1}.", typeof(Stype).Name, typeof(Stype).IsValueType);
            Console.WriteLine("The {0} type of Value Type is {1}.", typeof(Etype).Name, typeof(Etype).IsValueType);
            Console.WriteLine("\n");

            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(Etype).Name, typeof(Etype).BaseType);
            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(System.Enum).Name, typeof(System.Enum).BaseType);
            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(Int32).Name, typeof(Int32).BaseType);
            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(Stype).Name, typeof(Stype).BaseType);
            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(System.ValueType).Name, typeof(System.ValueType).BaseType);

            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(string).Name, typeof(string).BaseType);
            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(String).Name, typeof(String).BaseType);
            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(Ctype).Name, typeof(Ctype).BaseType);
            Console.WriteLine("The {0} type of Base Type is {1}.", typeof(System.Object).Name, typeof(System.Object).BaseType);



            Console.ReadLine();


        }

        public class Ctype
        {
            public int x = 1;
        }
        public enum Etype
        {
            a, b, c, d 
        }

        public struct Stype
        {
            public int x { get; set; }
        }
    }
}
