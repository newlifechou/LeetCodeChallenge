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
    public class LC004Tests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };

            double result = new LC004().FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(2.0,result);
        }
    }
}