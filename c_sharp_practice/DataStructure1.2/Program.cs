using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._2
{
    class Program
    {
        static void Main(string[] args)
        {


            //int n = 10;
            //List<int> input = new List<int> { 9, 7, 5, 5, 2, 9, 9, 9, 2, -1 };
            //TreeHeight.GetTreeHeight(input);
            string a = "57 51 34 39 74 97 -1 22 71 22 18 97 59 67 74 38 89 50 25 7 81 77 10 86 83 13 44 28 15 7 41 92 47 39 49 7 56 72 80 17 78 15 61 58 45 28 65 39 91 90 97 82 71 81 40 79 8 77 54 82 8 93 54 65 57 83 52 71 58 95 57 44 31 33 34 41 98 11 66 72 93 12 64 68 3 60 59 26 9 88 6 59 97 74 22 24 31 29 70 18";
            var input = a.Split(' ');

            //int n = Convert.ToInt32(Console.ReadLine());

            //var input = Console.ReadLine().Split(' ');
            List<int> intList = new List<int>();
            intList.AddRange(input.Select(s => int.Parse(s)));

            TreeHeight.GetTreeHeight(intList);


            Console.ReadLine();
        }

    }

    public static class TreeHeight
    {
        public static void GetTreeHeight(List<int> inputList)
        {

            List<TreeNode> TheList = new List<TreeNode>();

            TreeNode.BuildList(inputList.Count, ref TheList);

            TreeNode root = TheList[1];

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == -1)
                {
                    root = TheList[i];
                }
                else
                {
                    TreeNode cNode = TheList[i];
                    TreeNode pNode = TheList[inputList[i]];
                    pNode.AddChild(cNode);
                    //TreeNode.AddLink(pNode, cNode);
                }
            }
            Console.WriteLine("{0}", root.GetNodeHeight());
        }
    }

}
