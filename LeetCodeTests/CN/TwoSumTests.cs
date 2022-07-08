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
    public class TwoSumTests
    {
        [TestMethod()]
        public void Run3Test()
        {
            int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 11;

            var result = new TwoSum().Run3(nums, target);

            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 11);
        }
    }
}