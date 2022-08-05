using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 核心是遍历
    /// </summary>
    public class LC113
    {
        /// <summary>
        /// DFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            DFS(root, targetSum);
            return res;
        }

        private List<IList<int>> res = new List<IList<int>>();
        //临时存储路径
        private Stack<int> path = new Stack<int>();
        private void DFS(TreeNode root, int targetSum)
        {
            if (root == null)
                return;

            path.Push(root.val);
            targetSum -= root.val;
            //找到叶子后再存储
            if (root.left == null && root.right == null && targetSum == 0)
            {
                var tmp = new List<int>(path);
                tmp.Reverse();
                res.Add(tmp);
            }

            DFS(root.left, targetSum);
            DFS(root.right, targetSum);

            path.Pop();
        }


        /// <summary>
        /// BFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public IList<IList<int>> PathSum2(TreeNode root, int targetSum)
        {
            if (root == null)
                return null;
            Queue<TreeNode> qNode = new Queue<TreeNode>();
            Queue<int> qSum = new Queue<int>();
            qNode.Enqueue(root);
            qSum.Enqueue(0);

            while (qNode.Count!=0)
            {
                TreeNode node = qNode.Dequeue();
                int rec = qSum.Dequeue() + node.val;
                if (node.left == null && node.right == null)
                {
                    if (rec == targetSum)
                    {
                        GetPath(node);
                    }
                }
                else
                {
                    if (node.left != null)
                    {
                        map[node.left] = node;
                        qNode.Enqueue(node.left);
                        qSum.Enqueue(rec);
                    }
                    if (node.right != null)
                    {
                        map[node.right] = node;
                        qNode.Enqueue(node.right);
                        qSum.Enqueue(rec);
                    }
                }

            }

            return ans;
        }

        private List<IList<int>> ans = new List<IList<int>>();
        private Dictionary<TreeNode, TreeNode> map = new Dictionary<TreeNode, TreeNode>();

        private void GetPath(TreeNode node)
        {
            List<int> tmp = new List<int>();
            while (node != null)
            {
                tmp.Add(node.val);
                node = map[node];
            }
            tmp.Reverse();

            ans.Add(new List<int>(tmp));
        }

    }
}
