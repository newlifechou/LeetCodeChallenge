using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC104
    {
        /// <summary>
        /// 深度优先
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth1(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                int leftHeight = MaxDepth1(root.left);
                int rightHeight = MaxDepth1(root.right);
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }


        public int MaxDepth2(TreeNode root)
        {
            if (root == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int ans = 0;
            while (queue.Count!=0)
            {
                int size = queue.Count;
                while (size>0)
                {
                    TreeNode node = queue.Dequeue();
                    if(node.left!=null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    size--;
                }
                ans++;
            }

            return ans;
        }
    }
}
