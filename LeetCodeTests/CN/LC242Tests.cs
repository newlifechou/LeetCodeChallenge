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
    public class LC242Tests
    {
        [TestMethod()]
        public void IsAnagram1Test()
        {
            string s = "anagram";
            string t = "nagaram";

            bool result = new LC242().IsAnagram1(s, t);

            Assert.Fail();
        }
    }
}