using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList02.Tests
{

    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void LinkedListTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void LinkedListTest1()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void IsEmptyTest1()
        {
            LinkedList test = new LinkedList();
            bool expected = true;
            bool actual = test.IsEmpty();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsEmptyTest2()
        {
            LinkedList test = new LinkedList();
            test.AddFirst(1);
            bool expected = false;
            bool actual = test.IsEmpty();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ShowAllNodeTest()
        {
            LinkedList actual = new LinkedList();
            string expected = "This List is empty!\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                actual.ShowAllNode();
                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }


        }

        [TestMethod()]
        public void AddFirstTest()
        {
            LinkedList actual = new LinkedList(1);
            LinkedList expexted = new LinkedList();
            expexted.AddFirst(1);
            Assert.AreEqual(actual, actual);

        }

        [TestMethod()]
        public void GetFirstTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void PopFirstTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void AddLastTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void GetLastTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void PopLastTest()
        {
            throw new NotImplementedException();
        }
    }
}