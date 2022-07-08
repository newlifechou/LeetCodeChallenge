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
    public class LC067Tests
    {
        [TestMethod()]
        public void AddBinaryTest1()
        {
            string a = "11";
            string b = "1";
            string result = new LC067().AddBinary1(a, b);
            Assert.AreEqual("100", result);
        }

        [TestMethod()]
        public void AddBinaryTest2()
        {
            string a = "1010";
            string b = "1011";
            string result = new LC067().AddBinary1(a, b);
            Assert.AreEqual("10101", result);
        }

        [TestMethod()]
        public void AddBinary2Test1()
        {
            string a = "11";
            string b = "1";
            string result = new LC067().AddBinary2(a, b);
            Assert.AreEqual("100", result);
        }
        [TestMethod()]
        public void AddBinary2Test2()
        {
            string a = "1010";
            string b = "1011";
            string result = new LC067().AddBinary2(a, b);
            Assert.AreEqual("10101", result);
        }




    }
}