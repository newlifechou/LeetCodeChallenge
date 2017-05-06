using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
namespace LeetCodeTest
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 0, 4, 3, 0 };
            int target = 0;

            var test = new LeetCodeSolution();
            var result = test.TwoSum(nums, target);
            int[] expect = { 0, 3 };
            Assert.AreEqual(expect[0], result[0]);
            Assert.AreEqual(expect[1], result[1]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;

            var test = new LeetCodeSolution();
            var result = test.TwoSum(nums, target);
            int[] expect = { 2, 4 };
            Assert.AreEqual(expect[0], result[0]);
            Assert.AreEqual(expect[1], result[1]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { 1, 2, 3, 3, 4, 5 };
            int target = 8;

            var test = new LeetCodeSolution();
            var result = test.TwoSum(nums, target);
            int[] expect = { 2, 5};
            Assert.AreEqual(expect[0], result[0]);
            Assert.AreEqual(expect[1], result[1]);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nums = { 3,2,4 };
            int target = 6;

            var test = new LeetCodeSolution();
            var result = test.TwoSum(nums, target);
            int[] expect = { 1, 2 };
            Assert.AreEqual(expect[0], result[0]);
            Assert.AreEqual(expect[1], result[1]);
        }
    }
}
