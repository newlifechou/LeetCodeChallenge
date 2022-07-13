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
    public class LC795Tests
    {
        [TestMethod()]
        public void NumSubarrayBoundedMaxTest1()
        {
            int[] nums = { 2, 1, 4, 3 };
            int left = 2, right = 3;

            int result=new LC795().NumSubarrayBoundedMax(nums, left, right);

            Assert.AreEqual(3, result);
        }


        [TestMethod()]
        public void NumSubarrayBoundedMaxTest2()
        {
            int[] nums = { 2, 9, 2, 5,6 };
            int left = 2, right = 8;

            int result = new LC795().NumSubarrayBoundedMax(nums, left, right);

            Assert.AreEqual(7, result);
        }
    }
}