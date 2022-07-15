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
    public class LC456Tests
    {
        [TestMethod()]
        public void Find132patternTest()
        {
            int[] nums = { 3, 1, 4, 2 };
            bool result = new LC456().Find132pattern(nums);
            Assert.AreEqual(true,result);
        }
    }
}