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
    public class LC718Tests
    {
        [TestMethod()]
        public void FindLength1Test()
        {
            int[] nums1 = { 1, 2, 3, 2, 1 };
            int[] nums2 = { 3, 2, 1, 4, 7 };

            int result = new LC718().FindLength1(nums1, nums2);

            Assert.AreEqual(3, result);
        }
    }
}