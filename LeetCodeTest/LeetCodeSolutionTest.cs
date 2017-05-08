using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class LeetCodeSolutionTest
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            ListNode l1 = new LeetCode.ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var expect1 = 7;
            var expect2 = 0;
            var expect3 = 8;

            var result = new LeetCodeSolution().AddTwoNumbers(l1, l2);
            Assert.AreEqual(expect1, result.val);
            Assert.AreEqual(expect2, result.next.val);
            Assert.AreEqual(expect3, result.next.next.val);
        }

        [TestMethod()]
        public void AddTwoNumbersTest2()
        {
            ListNode l1 = new LeetCode.ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(9);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var expect1 = 7;
            var expect2 = 0;
            var expect3 = 4;
            var expect4 = 1;


            var result = new LeetCodeSolution().AddTwoNumbers(l1, l2);
            Assert.AreEqual(expect1, result.val);
            Assert.AreEqual(expect2, result.next.val);
            Assert.AreEqual(expect3, result.next.next.val);
            Assert.AreEqual(expect4, result.next.next.next.val);

        }

        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            string teststr = "abcabcbb";
            int expect = 3;
            int actual = new LeetCodeSolution().LengthOfLongestSubstring(teststr);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void ThreeSumTest()
        {
            int[] s = { -1, 0, 1, 2, -1, -4 };
            List<List<int>> expect = new List<List<int>>()
            {
                new List<int> {  -1, 0, 1 },
                new List<int> {  -1, -1, 2 }
            };

            Assert.AreEqual(expect[0][0], -1);
            Assert.AreEqual(expect[0][1], 0);
            Assert.AreEqual(expect[0][2], 1);
            Assert.AreEqual(expect[1][0], -1);
            Assert.AreEqual(expect[1][1], -1);
            Assert.AreEqual(expect[1][2], 2);
        }
    }
}