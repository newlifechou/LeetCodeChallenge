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
    public class LC030Tests
    {
        [TestMethod()]
        public void FindSubstringTest()
        {
            string s = "barfoothefoobarman";
            string[] words = { "foo", "bar" };
            var result = new LC030().FindSubstring(s, words);
            Assert.Fail();
        }
    }
}