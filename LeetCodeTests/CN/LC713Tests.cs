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
    public class LC713Tests
    {
        [TestMethod()]
        public void NumSubarrayProductLessThanKTest()
        {
            int[] nums = { 10, 5, 2, 6 };
            int k = 100;
            int result = new LC713().NumSubarrayProductLessThanK(nums, k);
            Assert.AreEqual(8, result);
        }
    }
}