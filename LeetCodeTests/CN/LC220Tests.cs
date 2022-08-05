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
    public class LC220Tests
    {
        [TestMethod()]
        public void ContainsNearbyAlmostDuplicateTest()
        {
            int[] nums = { 2147483640, 2147483641 };
            int k = 1;
            int t = 100;
            bool result = new LC220().ContainsNearbyAlmostDuplicate(nums, k, t);
            Assert.IsTrue(result);
        }
    }
}