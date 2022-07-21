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
    public class LC008Tests
    {
        [TestMethod()]
        public void MyAtoiTest()
        {
            int result = new LC008().MyAtoi("   -42");
            Assert.AreEqual(-42, result);
        }
    }
}