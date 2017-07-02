using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree01
{
    public class LinkedList<T>
    {
       protected class Node
        {
            public Node Next { get; set; }
            public T Value { get; set; }
        }

        protected Node _head;
        protected int _size;

        protected Node Head { get { return _head; } set { _head = value; } }

        public int Size {get{ return _size; }}

        public LinkedList()
        {
            Head = null;
            _size = 0;
        }
        public LinkedList(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Head = newNode;
            _size++;
        }

        public LinkedList(int number)
        {
            Node newNode = new Node();
            newNode.Value = default(T);
            Head = newNode;
            _size = number;
            for (int i = 1; i < number; i++)
            {
                this.AddLast(default(T));
            }
        }

        public LinkedList(int number, T value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Head = newNode;
            _size = number;
            for (int i = 1; i < number; i++)
            {
                this.AddLast(value);
            }
        }

        public bool IsEmpty()
        {
            return Head == null ? true : false;
        }

        public void ShowAllNode()
        {
            Node current = Head;
            if (IsEmpty())
            {
                Console.WriteLine("This List is empty!");
                return;
            }
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            Console.WriteLine("{0} element inside", count);

        }

        public virtual void AddFirst(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (IsEmpty())
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            _size++;

        }

        public T GetFirst()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return default(T);
            }
            return Head.Value;
        }

        public T PopFirst()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return default(T);
            }

            T result;
            result = Head.Value;
            Head = Head.Next;
            //Console.WriteLine("Pop: {0}", result);
            _size--;
            return result;
        }

        public T GetByIndex(int index)
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return default(T);
            }

            Node current = Head;
            int count = 0;
            while (count < index)
            {
                count++;
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine("Out of the range!");
                    return default(T);
                }
                     
            }

            return current.Value;
        }
        public virtual void AddLast(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if (IsEmpty())
            {
                Head = newNode;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            _size++;
        }

        public virtual T GetLast()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("No Element can be get!");
                return default(T);
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public virtual T PopLast()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return default(T);
            }
            _size--;
            if (Head.Next == null)
            {
                T tmp = Head.Value;
                Head = null;
                return tmp;
            }

            Node current = Head;
            T result;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            result = current.Value;
            current.Next = null;
            return result;
        }


    }
}
