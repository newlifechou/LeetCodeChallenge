using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC098
    {
        /// <summary>
        /// 递归思路
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsValidBST1(TreeNode root)
        {
            return Helper(root, long.MinValue, long.MaxValue);
        }

        private bool Helper(TreeNode node, long lower, long upper)
        {
            if (node == null)
                return true;
            if (node.val <= lower || node.val >= upper)
            {
                return false;
            }

            return Helper(node.left, lower, node.val) && Helper(node.right, node.val, upper);
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsValidBST2(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            double inOrder = double.MinValue;

            while (stack.Count != 0 || root != null)
            {
                while (root!=null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();

                if (root.val <= inOrder)
                {
                    return false;
                }
                inOrder = root.val;

                root = root.right;
            }

            return true;
        }
    }
}
