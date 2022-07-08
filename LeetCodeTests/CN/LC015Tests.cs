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
    public class LC015Tests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            var result = new LC015().ThreeSum(nums);
            var expected = new int[][] { new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } };

            Assert.AreEqual(expected, result);
        }
    }
}