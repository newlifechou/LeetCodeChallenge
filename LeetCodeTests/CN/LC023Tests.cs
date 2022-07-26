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
    public class LC023Tests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(4);
            head1.next.next = new ListNode(5);

            ListNode head2 = new ListNode(1);
            head2.next = new ListNode(3);
            head2.next.next = new ListNode(4);

            ListNode head3 = new ListNode(2);
            head3.next = new ListNode(6);

            ListNode[] nodes = new ListNode[] { head1, head2, head3 };
            ListNode result = new LC023().MergeKLists3(nodes);
            Assert.Fail();
        }
    }
}