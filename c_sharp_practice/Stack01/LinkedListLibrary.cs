using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack01
{
    public class LinkedList
    {
        protected class Node
        {
            public Node Next { get; set; }
            public int Value { get; set; }
        }

        protected Node _head;

        protected Node Head { get { return _head; } set { _head = value; } }

        public LinkedList()
        {
            Head = null;
        }
        public LinkedList(int value)
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
                //Console.WriteLine("This List is empty!");
                return;
            }
            Console.Write("Value = ");
            while (current != null)
            {
                Console.Write("{0}  ", current.Value);
                current = current.Next;
            }
            Console.WriteLine();

        }

        public virtual void AddFirst(int value)
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

        public int? GetFirst()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return null;
            }
            return Head.Value;
        }

        public int? PopFirst()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return null;
            }

            int result;
            result = Head.Value;
            Head = Head.Next;
            //Console.WriteLine("Pop: {0}", result);

            return result;
        }

        public virtual void AddLast(int value)
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

        public virtual int? GetLast()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("No Element can be get!");
                return null;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public virtual int? PopLast()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return null;
            }

            if (Head.Next == null)
            {
                int tmp = Head.Value;
                Head = null;
                return tmp;
            }

            Node current = Head;
            int result;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            result = current.Value;
            current.Next = null;
            return result;
        }


    }

    public class LinkedListTail : LinkedList
    {
        protected Node _tail;

        protected Node Tail { get { return _tail; } set { _tail = value; } }

        public LinkedListTail()
        {
            Head = null;
            Tail = null;
        }
        public LinkedListTail(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Head = newNode;
            Tail = newNode; ;
        }

        public override void AddFirst(int value)
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
                return;
            }

            if (Head == Tail)
            {
                Tail = newNode;
                Tail.Next = null;

                Head.Next = Tail;
            }

        }

        public override int? GetLast()
        {
            if (IsEmpty())
            {
                //Console.WriteLine("This List is empty!");
                return null;
            }
            return Tail.Value;
        }

        public override int? PopLast()
        {
            if (Head == null)
            {
                //Console.WriteLine("This List is empty!");
                return null;
            }

            int result;
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
