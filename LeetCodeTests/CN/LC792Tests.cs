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
    public class LC792Tests
    {
        [TestMethod()]
        public void NumMatchingSubseq1Test()
        {
            string S = "dcaotg";
            string[] words = { "dog", "cat", "cop" };

            int result = new LC792().NumMatchingSubseq1(S, words);

            Assert.AreEqual(2,result);
        }
    }
}