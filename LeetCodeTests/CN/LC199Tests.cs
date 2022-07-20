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
    public class LC199Tests
    {
        [TestMethod()]
        public void RightSideView1Test()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = null;
            root.left.right = new TreeNode(5);
            root.right.left = null;
            root.right.right = new TreeNode(4);
            var result = new LC199().RightSideView1(root);
            int[] expected = new int[3] { 1, 3, 4 };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}