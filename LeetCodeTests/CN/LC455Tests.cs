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
    public class LC455Tests
    {
        [TestMethod()]
        public void FindContentChildrenTest()
        {
            int[] g = { 10, 9, 8, 7 };
            int[] s = { 5, 6, 7, 8 };

            int result = new LC455().FindContentChildren(g, s);

            Assert.AreEqual(2, result);
        }
    }
}