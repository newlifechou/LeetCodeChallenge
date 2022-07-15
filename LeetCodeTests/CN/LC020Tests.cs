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
    public class LC020Tests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            string s = "(){}[]";
            bool result = new LC020().IsValid(s);
            Assert.IsTrue(result);
        }
    }
}