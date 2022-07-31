using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1161
    {
        public int MaxLevelSum(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int max = int.MinValue;
            int depth = 1;
            int ans = 0;
            queue.Enqueue(root);
            while (queue.Count!=0)
            {
                int sz = queue.Count, cur = 0;
                while (sz > 0)
                {
                    TreeNode t = queue.Dequeue();
                    if (t.left != null)
                    {
                        queue.Enqueue(t.left);
                    }
                    if (t.right != null)
                    {
                        queue.Enqueue(t.right);
                    }
                    cur += t.val;
                    sz--;
                }
                if (cur > max)
                {
                    max = cur;
                    ans = depth;
                }
                depth++;
            }

            return ans;

        }
    }
}
