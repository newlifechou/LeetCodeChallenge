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
        [TestMethod()]
        public void BinarySearchTest2()
        {
            int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 10;
            int expect = -1;
            int reality = new AlgorithmSolution().BinarySearch(key, arrays);
            Assert.AreEqual(expect, reality);
        }

        [TestMethod()]
        public void BinarySearchTest3()
        {
            int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 1;
            int expect = 0;
            int reality = new AlgorithmSolution().BinarySearch(key, arrays);
            Assert.AreEqual(expect, reality);
        }
        [TestMethod()]
        public void BinarySearchTest4()
        {
            const int count = 99999999;
            int[] arrays = new int[count];
            for (int i = 0; i < count; i++)
            {
                arrays[i] = i;
            }

            int key = 99999998;
            int expect = 99999998;
            int result = new AlgorithmSolution().BinarySearch(key, arrays);
            Assert.AreEqual(expect, result);

        }

        [TestMethod()]
        public void NormalSearchTest()
        {
            const int count = 99999999;
            int[] arrays = new int[count];
            for (int i = 0; i < count; i++)
            {
                arrays[i] = i;
            }

            int key = 99999998;
            int expect = 99999998;
            int result = new AlgorithmSolution().NormalSearch(key, arrays);
            Assert.AreEqual(expect, result);

        }

        [TestMethod()]
        public void ThreeNumberEqualTest()
        {
            int a, b, c;
            a = b = c = 5;
            Assert.AreEqual(true, new AlgorithmSolution().ThreeNumberEqual(a, b, c));
        }

        [TestMethod()]
        public void ThreeNumberEqualTest2()
        {
            int a, b, c;
            a = b  = 5;
            c = 0;
            Assert.AreNotEqual(true, new AlgorithmSolution().ThreeNumberEqual(a, b, c));
        }

    }
}