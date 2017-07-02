using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure1._2
{
    class TreeNode
    {

        public TreeNode parent { get; set; }
        public List<TreeNode> children { get; set; }
        public int value { get; set; }

        public int times { get; set; }


        public void AddChild(TreeNode childnode)
        {
            if (this.children == null)
            {
                this.children = new List<TreeNode>();
            }
            this.children.Add(childnode);
            childnode.parent = this;
        }

        public int GetNodeHeight()
        {
            if (this.children.Count == 0)
            {
                return 1;
            }
            int Max = 0;

            foreach (TreeNode item in this.children)
            {
                item.times++;

                int height = item.GetNodeHeight();

                if (height > Max)
                {
                    Max = height; 
                }
            }
            return Max + 1;
        }


        public static void AddLink(TreeNode pNode, TreeNode cNode)
        {
            pNode.children.Add(cNode);
            cNode.parent = pNode;
        }

        public static void BuildList(int number, ref List<TreeNode> MyList)
        {
            //List<TreeNode> MyList = new List<TreeNode>();
            for (int i = 0; i < number; i++)
            {
                TreeNode node = new TreeNode();
                node.children = new List<TreeNode>();
                node.value = i;
                node.times = 0;
                MyList.Add(node);
            }

        }

    }

}
