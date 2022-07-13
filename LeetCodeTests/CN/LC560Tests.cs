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
    public class LC560Tests
    {
        [TestMethod()]
        public void SubarraySumTest()
        {
            int[] nums = { 1, 1, 1 };
            int k = 2;
            int result = new LC560().SubarraySum(nums, k);
            Assert.AreEqual(2, result);
        }
    }
}