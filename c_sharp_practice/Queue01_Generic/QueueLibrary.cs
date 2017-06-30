using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01_Generic
{
    class MyQueue<T>
    {
        private LinkedListTail<T> list { get; set; }

        public MyQueue()
        {
            list = new LinkedListTail<T>();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Enqueue(T key)
        {
            list.AddLast(key);
        }

        public T TopFirst()
        {
            T result = list.GetFirst();

            if (result == null)
            {
                Console.WriteLine("This Queue is Empty!");
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

        public T Dequeue()
        {
            T result = list.PopFirst();

            if (result == null)
            {
                Console.WriteLine("This Queue is Empty!");
                return default(T);
            }
            return result;
        }
        public void ShowQueue()
        {
            list.ShowAllNode();
        }
    }
}
