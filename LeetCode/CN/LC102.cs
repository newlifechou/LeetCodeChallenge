using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC102
    {
       /// <summary>
       /// 利用队列进行层序遍历
       /// </summary>
       /// <param name="root"></param>
       /// <returns></returns>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if(root == null)
                return new List<IList<int>>();

            List<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count>0)
            {
                List<int> tmp = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode t = queue.Dequeue();
                    tmp.Add(t.val);
                    if (t.left != null)
                    {
                        queue.Enqueue(t.left);
                    }
                    if (t.right != null)
                    {
                        queue.Enqueue(t.right);
                    }
                }

                res.Add(tmp);
            }

            return res;
        }
    }
}
