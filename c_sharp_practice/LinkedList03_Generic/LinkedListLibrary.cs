using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList03_Generic
{
    public class LinkedList<T>
    {
        protected class Node
        {
            public Node Next { get; set; }
            public T Value { get; set; }
        }

        protected Node _head;

        protected Node Head { get { return _head; } set { _head = value; } }

        public LinkedList()
        {
            Head = null;
        }
        public LinkedList(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Head = newNode;
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
                //Tail = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;

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

    public class LinkedListTail<T> : LinkedList<T>
    {
        protected Node _tail;

        protected Node Tail { get { return _tail; } set { _tail = value; } }

        public LinkedListTail()
        {
            Head = null;
            Tail = null;
        }
        public LinkedListTail(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Head = newNode;
            Tail = newNode; ;
        }

        public override void AddFirst(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (IsEmpty())
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;

        }



        public override void AddLast(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }

            Tail.Next = newNode;
            Tail = newNode;

        }

        public override T GetLast()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return default(T);
            }
            return Tail.Value;
        }

        public override T PopLast()
        {
            if (Head == null)
            {
                //Console.WriteLine("This List is empty!");
                return default(T);
            }

            T result;
            result = Tail.Value;
            Node current = Head;
            if (Tail != null && Head == Tail)
            {
                Head = null;
                Tail = null;
                return result;
            }

            while (current.Next != Tail)
            {
                current = current.Next;
            }
            current.Next = null;
            Tail = current;

            //Console.WriteLine("Pop Last: {0}", result);

            return result;
        }


    }
}
