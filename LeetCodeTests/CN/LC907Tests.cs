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
    public class LC907Tests
    {
        [TestMethod()]
        public void SumSubarrayMinsTest1()
        {
            int[] nums = { 3, 1, 2, 4 };
            int result = new LC907().SumSubarrayMins(nums);
            Assert.AreEqual(17, result);
        }
        [TestMethod()]
        public void SumSubarrayMinsTest2()
        {
            int[] nums = { 11, 81, 94, 43, 3 };
            int result = new LC907().SumSubarrayMins(nums);
            Assert.AreEqual(444, result);
        }
    }
}