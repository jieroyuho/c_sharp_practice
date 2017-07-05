using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure1._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._3.Tests
{
    [TestClass()]
    public class TimeProcessTests
    {
        [TestMethod()]
        public void ProcessTest()
        {
            for (int i = 1; i <= 22; i++)
            {

                string s1 = @".\tests\" + String.Format("{0:00}", i);
                string s2 = @".\tests\" + String.Format("{0:00}", i) + ".a";

                string t1 = System.IO.File.ReadAllText(s1);
                string t2 = System.IO.File.ReadAllText(s2);

                string Delimiter = "\r\n";
                var t1SplitRN = t1.Split(new[] { Delimiter }, StringSplitOptions.None);


                var inputFirstLine = t1SplitRN[0].Split(' ');

                int bufferSize = Int32.Parse(inputFirstLine[0]);
                int packNumber = Int32.Parse(inputFirstLine[1]);

                List<Pack> inputList = new List<Pack>();

                for (int j = 1; j <= packNumber; j++)
                {
                    var packInput = t1SplitRN[j].Split(' ');
                    Pack thepack = new Pack(Int32.Parse(packInput[0]), Int32.Parse(packInput[1]), j - 1);
                    inputList.Add(thepack);
                }


                string expected = t2;
                using (var consoleOutput = new ConsoleOutput())
                {
                    TimeProcess.Process(bufferSize, inputList);
                    string error = "Case" + String.Format("{0:00}", i);
                    Assert.AreEqual(expected, consoleOutput.GetOuput(), error);
                }
            }
        }
    }
}