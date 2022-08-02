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
    public class LC113Tests
    {
        [TestMethod()]
        public void PathSumTest()
        {
            TreeNode root = new TreeNode(5);
            TreeNode left1 = new TreeNode(4);
            TreeNode right1 = new TreeNode(8);
            root.left= left1;
            root.right = right1;

            TreeNode left11 = new TreeNode(11);
            left1.left= left11;

            left11.left = new TreeNode(7);
            left11.right = new TreeNode(2);

            right1.left = new TreeNode(13);
            var right11 = new TreeNode(4);
            right1.right = right11;

            right11.left = new TreeNode(5);
            right11.right = new TreeNode(1);

            var result=new LC113().PathSum(root,22);
            Assert.Fail();
        }
    }
}