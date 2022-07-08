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
    public class SearchTests
    {
        int[] data;
        [TestInitialize]
        public void Init()
        {
            data = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }


        [TestMethod()]
        public void rankTest()
        {
            int result = new Search().rank(6, data);

            Assert.AreEqual(5,result);
        }
    }
}