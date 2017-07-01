using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree01
{
    class Node
    {
        
        public Node parent { get; set; }
        public List<Node> children { get; set; }
        public int value { get; set; }

        public Node()
        {
            //this.children = new List<Node>();
        }
        //public Node(int key)
        //{
        //    this.value = key;
        //    this.children = new List<Node>();
        //}

        public void AddChild (Node childnode)
        {
            if (this.children == null)
            {
                this.children = new List<Node>();
            }
            this.children.Add(childnode);
            childnode.parent = this;
        }

        public int GetNodeHeight()
        {
            if(children == null)
            {
                return 1;
            }
            int Max = 0;
            foreach (Node item in this.children)
            {
                //Console.WriteLine("Node[{0}] Get")

                if (item.GetNodeHeight() > Max)
                {
                    Max = item.GetNodeHeight();
                }
            }
            return Max + 1;
        }


        public static void AddLink(Node pNode, Node cNode)
        {
            pNode.children.Add(cNode);
            cNode.parent = pNode;
        }


    }

}
