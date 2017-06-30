using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine();

            BracketCheck.check(text);

            Console.ReadLine();
        }
    }

    public static class BracketCheck
    {
        public static void check(string text)
        {
            bool checkResult = false;
            //int errorIndex = 0;

            MyStack<Bracket> bracketStack = new MyStack<Bracket>();

            for (int i = 0; i < text.Length; i++)
            {
                char next = text[i];

                if (next == '(' || next == '[' || next == '{')
                {
                    Bracket current = new Bracket(next, i);
                    checkResult = false;
                    bracketStack.Push(current);
                }

                if (next == ')' || next == ']' || next == '}')
                {
                    Bracket current = bracketStack.Top();
                    if ((next == ')' && current.type == '(') ||
                        (next == '}' && current.type == '{') ||
                        (next == ']' && current.type == '['))
                    {
                        checkResult = true;
                        bracketStack.Pop();
                    }
                    else
                    {
                        Bracket errorTop = new Bracket(next, i);
                        checkResult = false;
                        bracketStack.Push(errorTop); 
                        // Push the first error and break, the Stack.Top will get the error position
                        break;
                    }
                }
            }



            if (checkResult == true)
            {
                if (bracketStack.IsEmpty())
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Bracket topNode = bracketStack.Top();
                    Console.WriteLine("{0}", topNode.position + 1);
                }
            }
            else
            {
                Bracket topNode = bracketStack.Top();
                Console.WriteLine("{0}", topNode.position + 1);
            }

        }

    }

    public struct Bracket
    {
        public char type;
        public int position;
        public Bracket(char type, int position)
        {
            this.type = type;
            this.position = position;
        }
        public bool Match(char c)
        {
            if (this.type == '[' && c == ']')
                return true;
            if (this.type == '{' && c == '}')
                return true;
            if (this.type == '(' && c == ')')
                return true;
            return false;
        }

    }



}
