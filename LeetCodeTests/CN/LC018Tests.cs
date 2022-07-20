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
    public class LC018Tests
    {
        [TestMethod()]
        public void FourSumTest()
        {
            int[] nums = { 1000000000, 1000000000, 1000000000, 1000000000 };
            var result=new LC018().FourSum(nums,-294967296);
            Assert.Fail();
        }
    }
}