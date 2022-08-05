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
    public class LC567Tests
    {
        [TestMethod()]
        public void CheckInclusion1Test1()
        {
            string s1 = "ab";
            string s2 = "eidbaooo";
            bool result = new LC567().CheckInclusion1(s1, s2);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CheckInclusion1Test2()
        {
            string s1 = "ab";
            string s2 = "eidboaoo";
            bool result = new LC567().CheckInclusion1(s1, s2);
            Assert.IsFalse(result);
        }
    }
}