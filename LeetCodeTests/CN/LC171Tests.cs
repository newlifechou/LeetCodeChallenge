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
    public class LC171Tests
    {
        [TestMethod()]
        public void TitleToNumberTest()
        {

            int ans = new LC171().TitleToNumber("ZY");
            Assert.AreEqual(701,ans);
        }
    }
}