using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure1._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1._1.Tests
{
    [TestClass()]
    public class BracketCheckTests
    {
        [TestMethod()]
        public void checkTest()
        {

            for (int i = 1; i <= 54; i++)
            {
                string s1 = @".\tests\" + String.Format("{0:00}", i);
                string s2 = @".\tests\" + String.Format("{0:00}", i) + ".a";

                string t1 = System.IO.File.ReadAllText(s1);
                string t2 = System.IO.File.ReadAllText(s2);


                string expected = t2;
                using (var consoleOutput = new ConsoleOutput())
                {
                    BracketCheck.check(t1);
                    string error = "Case" + String.Format("{0:00}", i);
                    Assert.AreEqual(expected, consoleOutput.GetOuput(), error);
                }
            }


        }

    }
}