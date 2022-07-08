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
    public class LC258Tests
    {
        [TestMethod()]
        public void AddDigits1Test()
        {

            int num = 38;
            int result = new LC258().AddDigits1(num);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void AddDigits2Test()
        {
            int num = 38;
            int result = new LC258().AddDigits2(num);
            Assert.AreEqual(2, result);
        }
    }
}