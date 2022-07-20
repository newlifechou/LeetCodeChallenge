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
    public class LC035Tests
    {
        [TestMethod()]
        public void SearchInsertTest()
        {
            int[] nums = { 1, 3, 5, 6 };
            int k = 5;
            int expect = 2;
            int result = new LC035().SearchInsert(nums, k);
            Assert.AreEqual(expect,result);
        }
    }
}