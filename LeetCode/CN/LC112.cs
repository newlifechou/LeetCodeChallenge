using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC112
    {
        /// <summary>
        /// BFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            //要遍历的Node
            Queue<TreeNode> qNode = new Queue<TreeNode>();
            //路径和
            Queue<int> qVal = new Queue<int>();

            qNode.Enqueue(root);
            qVal.Enqueue(root.val);

            while (qNode.Count != 0)
            {
                TreeNode current = qNode.Dequeue();
                int tmp = qVal.Dequeue();
                if (current.left == null && current.right == null)
                {
                    if (tmp == targetSum)
                    {
                        return true;
                    }
                    continue;
                }

                if (current.left != null)
                {
                    qNode.Enqueue(current.left);
                    qVal.Enqueue(current.left.val + tmp);
                }
                if (current.right != null)
                {
                    qNode.Enqueue(current.right);
                    qVal.Enqueue(current.right.val + tmp);
                }

            }

            return false;
        }

        /// <summary>
        /// 递归思想
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public bool HasPathSum2(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null)
            {
                return targetSum == root.val;
            }

            return HasPathSum2(root.left, targetSum - root.val) || HasPathSum2(root.right, targetSum - root.val);

        }


    }
}
