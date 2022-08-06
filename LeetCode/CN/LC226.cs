using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 翻转二叉树
    /// 左右互换
    /// </summary>
    internal class LC226
    {
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);
            root.left = right;
            root.right = left;
            return root;
        }


    }
}
