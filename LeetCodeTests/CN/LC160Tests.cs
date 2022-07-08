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
    public class LC160Tests
    {
        [TestMethod()]
        public void GetIntersectionNode3Test()
        {
            ListNode node1 = new ListNode(4);
            ListNode node2 = new ListNode(1);
            ListNode node3 = new ListNode(8);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);

            ListNode node6 = new ListNode(5);
            ListNode node7 = new ListNode(0);
            ListNode node8 = new ListNode(1);

            ListNode headA = node1;
            ListNode headB = node6;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            node6.next = node7;
            node7.next = node8;
            node8.next = node3;

            ListNode result = new LC160().GetIntersectionNode3(headA, headB);
            Assert.AreSame(result, node3);
        }
    }
}