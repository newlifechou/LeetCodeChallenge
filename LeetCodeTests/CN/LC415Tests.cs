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
    public class LC415Tests
    {
        [TestMethod()]
        public void AddStringsTest1()
        {
            string num1 = "11", num2 = "123";
            string result=new LC415().AddStrings(num1, num2);
            Assert.AreEqual("134", result);
        }
        [TestMethod()]
        public void AddStringsTest2()
        {
            string num1 = "456", num2 = "77";
            string result = new LC415().AddStrings(num1, num2);
            Assert.AreEqual("533", result);
        }
        [TestMethod()]
        public void AddStringsTest3()
        {
            string num1 = "0", num2 = "0";
            string result = new LC415().AddStrings(num1, num2);
            Assert.AreEqual("0", result);
        }
    }
}