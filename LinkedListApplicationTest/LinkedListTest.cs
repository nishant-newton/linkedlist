using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListApplication;

namespace LinkedListApplicationTest
{
    [TestClass]
    public class LinkedListTest
    {
        #region Positive Test Cases
        [TestMethod]
        public void TestCreateLinkedList()
        {
            try
            {
                var linkedList = new LinkedList();
                for (int i = 2; i < 12; i++)
                    linkedList.Add(i);
                Assert.IsNotNull(linkedList);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);                
            }
        }

        [TestMethod]
        public void TestShowLinkedList()
        {
            var linkedList = new LinkedList();
            for (int i = 2; i < 12; i++)
                linkedList.Add(i);
            Assert.IsNotNull(linkedList);
            var headNode = linkedList.GetHeadNode;
            int startValue = 2;
            while (headNode != null)
            {
                Assert.AreEqual(startValue, headNode.Data);
                startValue++;
                headNode = headNode.Next;
            }
        }

        [TestMethod]
        public void TestGetNthNode()
        {
            var linkedList = new LinkedList();
            string errorMessage = string.Empty;
            int position = 5;
            int output = 7;
            for (int i = 2; i < 12; i++)
                linkedList.Add(i);
            Assert.IsNotNull(linkedList);
            var node = linkedList.GetNthNode(position,out errorMessage);
            Assert.IsNotNull(node);
            Assert.AreEqual(errorMessage, String.Empty);
            Assert.AreEqual(output, node.Data);
        }
         #endregion

        #region Negative Test Case
        [TestMethod]
        public void TestErrorMessage()
        {
            var linkedList = new LinkedList();
            string errorMessage = string.Empty;
            int position = 5;            
            for (int i = 2; i < 5; i++)
                linkedList.Add(i);
            Assert.IsNotNull(linkedList);
            var node = linkedList.GetNthNode(position, out errorMessage);
            Assert.IsNull(node);
        }

        #endregion
    }
}
