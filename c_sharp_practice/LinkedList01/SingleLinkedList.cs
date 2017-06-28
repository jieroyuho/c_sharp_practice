using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList01
{

    public class SingleLinkedList
    {
        private class Node
        {
            public Node Next { get; set; }
            public int Value { get; set; }

        }


        private Node _head;
        private Node _tail;

        private Node Head { get{ return _head;} set{ _head = value;}}
        private Node Tail { get{ return _tail;} set{ _tail = value; }}

        public SingleLinkedList()
        {
            Head = null;
            Tail = null;
        }
        public SingleLinkedList(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Head = newNode;
            Tail = newNode; ;
        }

        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowAllNode()
        {
            Node current = Head;

            if (IsEmpty())
            {
                Console.WriteLine("This Linked List is empty!");
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


        public void AddFirst(int value)
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

        public int? GetFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("No Element can be get!");
                return null;
            }
            return Head.Value;
        }



        public int? PopFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("No Element can be pop out!");
                return null;
            }

            int result;
            result = Head.Value;
            Head = Head.Next;
            Console.WriteLine("Pop First: {0}", result);

            return result;
        }

        public void AddLast(int value)
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

        public int? GetLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("No Element can be get!");
                return null;
            }
            return Tail.Value;
        }


        public int? PopLast()
        {
            if (Head == null)
            {
                Console.WriteLine("No Element can be pop out!");
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

            Console.WriteLine("Pop Last: {0}", result);

            return result;
        }

        public void RemoveKey(int key)
        {
            if(IsEmpty())
            {
                Console.WriteLine("The List is empty, no need to remove!\n");
                return;
            }

            if (!SingleRemove(key))
            {
                Console.WriteLine("Not Found!\n");
            }
            return;

        }
        public void RemoveAllKey(int key)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The List is empty, no need to remove!\n");
                return;
            }

            if (AllRemove(key) == 0)
            {
                Console.WriteLine("Not Found!\n");
            }
            return;

        }

        public bool SingleRemove(int key)
        {
            if (Head.Value == key)
            {
                Head = Head.Next;
                Console.WriteLine("Removed the first of Key {0}\n", key);
                return true;
            }

            Node current = Head;

            while (current.Next != null)
            {
                if (current.Next.Value == key)
                {
                    Console.WriteLine("Removed the first of Key {0}\n", key);
                    if (current.Next.Next == null)
                    {
                        Tail = current;
                        current.Next = null;
                        break;
                    }

                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;

        }

        public int AllRemove(int key)
        {
           
            int count = 0;
            while (Head.Value == key)
            {
                Head = Head.Next;
                //Console.WriteLine("Removed the Key {0}", key);
                count++;
            }

            Node current = Head;
            
            while (current.Next != null)
            {
                if (current.Next.Value == key)
                {
                    //Console.WriteLine("Removed the Key {0}", key);
                    if (current.Next.Next == null)
                    {
                        Tail = current;
                        current.Next = null;
                        count++;
                        break;
                    }

                    current.Next = current.Next.Next;
                    count++;
                }
                current = current.Next;
            }
            Console.WriteLine("Removed the Key \"{0}\" by {1} time\n", key, count);
            return count++;

        }

    }



}
