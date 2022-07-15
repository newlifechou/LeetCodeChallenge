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
    public class LC739Tests
    {
        [TestMethod()]
        public void DailyTemperaturesTest()
        {
            int[] temperatures = { 30, 40, 50, 60 };
            int[] expect = { 1, 1, 1, 0 };

            int[] result = new LC739().DailyTemperatures(temperatures);
            Assert.AreEqual(expect, result);
        }
    }
}