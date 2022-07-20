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
    public class LC452Tests
    {
        [TestMethod()]
        public void FindMinArrowShotsTest()
        {
            int[][] nums = new int[4][];
            nums[0] = new int[] { 10, 16 };
            nums[1] = new int[] { 2, 8 };
            nums[2] = new int[] { 1, 6 };
            nums[3] = new int[] { 7, 12 };

            int result = new LC452().FindMinArrowShots(nums);

            Assert.AreEqual(2,result);
        }
    }
}