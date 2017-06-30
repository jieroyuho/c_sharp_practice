using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack01
{
    class Stack
    {
        private LinkedListTail list { get; set; }

        public Stack()
        {
            list = new LinkedListTail();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Push(int key)
        {
            list.AddFirst(key);
        }

        public int? Top()
        {
            int? result = list.GetFirst();

            if (result == null)
            {
                Console.WriteLine("This Stack is Empty!");
            }
            return result;
        }

        public int? Pop()
        {
            int? result = list.PopFirst();

            if (result == null)
            {
                Console.WriteLine("This Stack is Empty!");
            }
            return result;
        }
        public void ShowStack()
        {
            list.ShowAllNode();
        }
    }
}
