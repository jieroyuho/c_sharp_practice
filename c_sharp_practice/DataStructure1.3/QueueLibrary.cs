using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._3
{
    class MyQueue<T>
    {
        private int _buffer;
        private int _count;
        private LinkedListTail<T> list { get; set; }
        public int Buffer { get { return _buffer; } set { _buffer = value; } }
        public int Count { get { return _count; } set { _count = value; } }

        public MyQueue()
        {
            this.Buffer = 2000;
            this.Count = 0;
            list = new LinkedListTail<T>();
        }
        public MyQueue(int buffer)
        {
            this.Buffer = buffer;
            this.Count = 0;
            list = new LinkedListTail<T>();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public int Enqueue(T value)
        {
            if (this.Buffer == this.Count)
            {
                return -1;
            }
            else
            {
                Count++;
                list.AddLast(value);
                return 0;
            }
        }

        public T TopFirst()
        {
            T result = list.GetFirst();

            if (result == null)
            {
                //Console.WriteLine("This Queue is Empty!");
                return default(T);
            }
            return result;
        }

        public T TopByIndex(int offset)
        {
            if (offset + 1 <= this.Count)
            {
                T result = list.GetByIndex(offset);
                return result;
            }
            else
            {
                return default(T);
            }

            //if (result == null)
            //{
            //Console.WriteLine("Out of the range!");
            //        return default(T);
            //    }
            //    return result;
        }

        public T Dequeue()
        {
            if (this.Count >= 1)
            {
                this.Count--;
                T result = list.PopFirst();
                return result;
            }
            else
            {
                return default(T);
            }
            //if (result == null)
            //{
            //    Console.WriteLine("This Queue is Empty!");
            //    return default(T);
            //}
            //return result;
        }
        public void ShowQueue()
        {
            list.ShowAllNode();
        }
    }
}
