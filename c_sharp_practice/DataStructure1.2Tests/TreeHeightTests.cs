using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure1._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._2.Tests
{
    [TestClass()]
    public class TreeHeightTests
    {
        [TestMethod()]
        public void GetTreeHeightTest()
        {

            //int n = Convert.ToInt32(Console.ReadLine());

            //var input = Console.ReadLine().Split(' ');

            //List<int> intList = new List<int>();
            //intList.AddRange(input.Select(s => int.Parse(s)));


            for (int i = 1; i <= 24; i++)
            {

                string s1 = @".\tests\" + String.Format("{0:00}", i);
                string s2 = @".\tests\" + String.Format("{0:00}", i) + ".a";

                string t1 = System.IO.File.ReadAllText(s1);
                string t2 = System.IO.File.ReadAllText(s2);

                var t1SplitN = t1.Split('\n');            // For Windows with /r/n
                var t1SplitR = t1SplitN[1].Split('\r');
                string[] input = t1SplitR[0].Split(' ');

                //var t1Split = t1.Split('\n');           // For Unix with /n
                //string[] input = t1Split[1].Split(' ');
                List<int> intList = new List<int>();
                intList.AddRange(input.Select(s => int.Parse(s)));
                string expected = t2;
                using (var consoleOutput = new ConsoleOutput())
                {
                    TreeHeight.GetTreeHeight(intList);
                    string error = "Case" + String.Format("{0:00}", i);
                    Assert.AreEqual(expected, consoleOutput.GetOuput(), error);
                }
            }
        }
    }
}