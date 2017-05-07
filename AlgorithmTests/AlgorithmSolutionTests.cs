using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class AlgorithmSolutionTests
    {
        [TestMethod()]
        public void BinarySearchTest()
        {
            int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 8;
            int expect = 7;
            int reality = new AlgorithmSolution().BinarySearch(key, arrays);
            Assert.AreEqual(expect, reality);
        }
    }
}