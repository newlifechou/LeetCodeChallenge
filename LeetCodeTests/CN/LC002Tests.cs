using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.CN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN.Tests
{
    [TestClass()]
    public class LC002Tests
    {
        [TestMethod()]
        public void AddTwoNumbers1Test1()
        {
            ListNode node1 = new ListNode(2);
            ListNode node2 = new ListNode(4);
            ListNode node3 = new ListNode(3);

            node1.next = node2;
            node2.next = node3;

            ListNode node4 = new ListNode(5);
            ListNode node5 = new ListNode(6);
            ListNode node6 = new ListNode(4);

            node4.next = node5;
            node5.next = node6;

            ListNode result = new LC002().AddTwoNumbers2(node1, node4);

            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
        }

        [TestMethod()]
        public void AddTwoNumbers1Test2()
        {
            ListNode node11 = new ListNode(9);
            ListNode node12 = new ListNode(9);
            ListNode node13 = new ListNode(9);
            ListNode node14 = new ListNode(9);
            ListNode node15 = new ListNode(9);
            ListNode node16 = new ListNode(9);
            ListNode node17 = new ListNode(9);

            node11.next = node12;
            node12.next = node13;
            node13.next = node14;
            node14.next = node15;
            node15.next = node16;
            node16.next = node17;

            ListNode node24 = new ListNode(9);
            ListNode node25 = new ListNode(9);
            ListNode node26 = new ListNode(9);
            ListNode node27 = new ListNode(9);

            node24.next = node25;
            node25.next = node26;
            node26.next = node27;

            ListNode result = new LC002().AddTwoNumbers2(node11, node24);

            Assert.AreEqual(8, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(1, result.val);
        }

        [TestMethod()]
        public void AddTwoNumbers2Test()
        {
            ListNode node11 = new ListNode(9);
            ListNode node12 = new ListNode(9);
            ListNode node13 = new ListNode(9);
            ListNode node14 = new ListNode(9);
            ListNode node15 = new ListNode(9);
            ListNode node16 = new ListNode(9);
            ListNode node17 = new ListNode(9);

            node11.next = node12;
            node12.next = node13;
            node13.next = node14;
            node14.next = node15;
            node15.next = node16;
            node16.next = node17;

            ListNode node24 = new ListNode(9);
            ListNode node25 = new ListNode(9);
            ListNode node26 = new ListNode(9);
            ListNode node27 = new ListNode(9);

            node24.next = node25;
            node25.next = node26;
            node26.next = node27;

            ListNode result = new LC002().AddTwoNumbers2(node11, node24);

            Assert.AreEqual(8, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(1, result.val);


        }

        [TestMethod()]
        public void LinkNodeToIntTest()
        {
            ListNode node11 = new ListNode(8);
            ListNode node12 = new ListNode(0);
            ListNode node13 = new ListNode(7);

            node11.next = node12;
            node12.next = node13;


            int result = new LC002().ListNodeToInt(node11);

            Assert.AreEqual(708, result);
        }

        [TestMethod()]
        public void IntToListNodeTest()
        {

            ListNode result = new LC002().IntToListNode(708);
            Assert.AreEqual(8, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(7, result.val);
        }

        [TestMethod()]
        public void AddTwoNumbers3Test()
        {
            ListNode node11 = new ListNode(9);
            ListNode node12 = new ListNode(9);
            ListNode node13 = new ListNode(9);
            ListNode node14 = new ListNode(9);
            ListNode node15 = new ListNode(9);
            ListNode node16 = new ListNode(9);
            ListNode node17 = new ListNode(9);

            node11.next = node12;
            node12.next = node13;
            node13.next = node14;
            node14.next = node15;
            node15.next = node16;
            node16.next = node17;

            ListNode node24 = new ListNode(9);
            ListNode node25 = new ListNode(9);
            ListNode node26 = new ListNode(9);
            ListNode node27 = new ListNode(9);

            node24.next = node25;
            node25.next = node26;
            node26.next = node27;

            ListNode result = new LC002().AddTwoNumbers3(node11, node24);

            Assert.AreEqual(8, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(1, result.val);
        }

        [TestMethod()]
        public void AddTwoNumbers4Test()
        {
            ListNode node11 = new ListNode(9);
            ListNode node12 = new ListNode(9);
            ListNode node13 = new ListNode(9);
            ListNode node14 = new ListNode(9);
            ListNode node15 = new ListNode(9);
            ListNode node16 = new ListNode(9);
            ListNode node17 = new ListNode(9);

            node11.next = node12;
            node12.next = node13;
            node13.next = node14;
            node14.next = node15;
            node15.next = node16;
            node16.next = node17;

            ListNode node24 = new ListNode(9);
            ListNode node25 = new ListNode(9);
            ListNode node26 = new ListNode(9);
            ListNode node27 = new ListNode(9);

            node24.next = node25;
            node25.next = node26;
            node26.next = node27;

            ListNode result = new LC002().AddTwoNumbers4(node11, node24);

            Assert.AreEqual(8, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(9, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(0, result.val);
            result = result.next;
            Assert.AreEqual(1, result.val);
        }
    }
}