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
    public class LC290Tests
    {
        [TestMethod()]
        public void WordPatternTest()
        {
            string pattern = "abba";
            string s = "dog cat cat dog";
            bool result = new LC290().WordPattern(pattern, s);

            Assert.IsTrue(result);
        }
    }
}