using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 右视树
    /// </summary>
    public class LC199
    {
        /// <summary>
        /// 深度优先搜索
        /// 对树进行深度优先搜索，在搜索过程中，我们总是先访问右子树。
        /// 那么对于每一层来说，我们在这层见到的第一个结点一定是最右边的结点。
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView1(TreeNode root)
        {
            Dictionary<int, int> rightMost = new Dictionary<int, int>();

            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            Queue<int> depthQueue = new Queue<int>();
            List<int> rightView = new List<int>();

            if (root == null)
                return rightView;


            nodeQueue.Enqueue(root);
            depthQueue.Enqueue(0);
            int max_depth = -1;

            while (nodeQueue.Count != 0)
            {
                TreeNode currentNode = nodeQueue.Dequeue();
                int depth = depthQueue.Dequeue();
                max_depth = Math.Max(max_depth, depth);

                if (currentNode != null)
                {
                    //当前层第一个出来的节点
                    if (!rightMost.ContainsKey(depth))
                    {
                        rightMost[depth] = currentNode.val;
                    }

                    if (currentNode.right != null)
                    {
                        nodeQueue.Enqueue(currentNode.right);
                        depthQueue.Enqueue(depth + 1);
                    }

                    //处理null值
                    if (currentNode.left != null)
                    {
                        nodeQueue.Enqueue(currentNode.left);
                        depthQueue.Enqueue(depth + 1);
                    }



                }
            }

            for (int depth = 0; depth <= max_depth; depth++)
            {
                rightView.Add(rightMost[depth]);
            }

            return rightView;

        }


        /// <summary>
        /// 广度有限搜索
        /// 每层最右的节点最后被访问到
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView2(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root == null)
                return res;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    //放入当前层的最后一个节点到结果列表
                    if (i == queue.Count - 1)
                    {
                        res.Add(node.val);
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// DFS递归
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView3(TreeNode root)
        {
            List<int> res = new List<int>();
            Dfs(res, root, 0);
            return res;
        }

        private void Dfs(List<int> res, TreeNode node, int level)
        {
            if (node != null)
            {
                if (res.Count == level)
                {
                    res.Add(node.val);
                }
                Dfs(res, node.right, level + 1);
                Dfs(res, node.left, level + 1);
            }
        }

    }
}
