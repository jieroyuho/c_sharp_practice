using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            List<TreeNode> TheList = new List<TreeNode>();

            TreeNode.BuildList(n, ref TheList);

            int[] l = new int[]{ -1, 0, 4, 0, 3 };

            TreeNode root = TheList[1];

            for (int i = 0; i < 5;  i++)
            {
                if (l[i] == -1)
                {
                    root = TheList[i];
                }
                else
                {
                    TreeNode cNode = TheList[i];
                    TreeNode pNode = TheList[l[i]];
                    TreeNode.AddLink(pNode, cNode);
                }
            }
            Console.WriteLine("{0}", root.GetNodeHeight());


            Console.ReadLine();
        }


    }
}
