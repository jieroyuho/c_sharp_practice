using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._1
{
    class MyStack<T>
    {
        private LinkedListTail<T> list { get; set; }

        public MyStack()
        {
            list = new LinkedListTail<T>();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Push(T key)
        {
            list.AddFirst(key);
        }

        public T Top()
        {
            T result = list.GetFirst();

            if (result == null)
            {
                Console.WriteLine("This Stack is Empty!");
                return default(T);
            }
            return result;
        }

        public T TopByIndex(int offset)
        {
            T result = list.GetByIndex(offset);

            if (result == null)
            {
                Console.WriteLine("Out of the range!");
                return default(T);
            }
            return result;
        }

        public T Pop()
        {
            T result = list.PopFirst();

            if (result == null)
            {
                Console.WriteLine("This Stack is Empty!");
                return default(T);
            }
            return result;
        }
        public void ShowStack()
        {
            list.ShowAllNode();
        }
    }
}
