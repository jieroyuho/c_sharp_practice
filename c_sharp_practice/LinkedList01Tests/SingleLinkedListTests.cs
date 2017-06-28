using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList01.Tests
{
    [TestClass()]
    public class SingleLinkedListTests
    {
        [TestMethod()]
        public void SingleLinkedListTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void SingleLinkedListTest1()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            SingleLinkedList sll = new SingleLinkedList();
            bool actual = sll.IsEmpty();
            bool expected = true;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void ShowAllNodeTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void AddFirstTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetFirstTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void PopFirstTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void AddLastTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetLastTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void PopLastTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void RemoveKeyTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void SingleRemoveTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void AllRemoveTest()
        {
            //Assert.Fail();
        }
    }
}