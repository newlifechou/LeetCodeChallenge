using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC257
    {
        /// <summary>
        /// 深度优先
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<string> BinaryTreePaths1(TreeNode root)
        {
            List<string> paths = new List<string>();
            GetPaths(root, "", paths);
            return paths;
        }

        private void GetPaths(TreeNode root, string path, List<string> paths)
        {
            if (root != null)
            {
                StringBuilder path_sb = new StringBuilder(path);
                path_sb.Append(root.val.ToString());
                //叶子结点，结束
                if (root.left == null && root.right == null)
                {
                    paths.Add(path_sb.ToString());
                }
                else
                {
                    path_sb.Append("->");
                    GetPaths(root.left, path_sb.ToString(), paths);
                    GetPaths(root.right, path_sb.ToString(), paths);
                }
            }
        }



        /// <summary>
        /// 广度优先
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<string> BinaryTreePaths2(TreeNode root)
        {
            List<string> paths = new List<string>();
            if (root == null)
                return paths;

            Queue<TreeNode> qNode = new Queue<TreeNode>();
            Queue<string> qPath = new Queue<string>();

            qNode.Enqueue(root);
            qPath.Enqueue(root.val.ToString());

            while (qNode.Count != 0)
            {
                TreeNode node = qNode.Dequeue();
                string path = qPath.Dequeue();

                if (node.left != null && node.right == null)
                {
                    paths.Add(path);
                }
                else
                {
                    if (node.left != null)
                    {
                        qNode.Enqueue(node.left);
                        qPath.Enqueue(new StringBuilder(path).Append("->").Append(node.left.val).ToString());
                    }

                    if (node.right != null)
                    {
                        qNode.Enqueue(node.right);
                        qPath.Enqueue(new StringBuilder(path).Append("->").Append(node.right.val).ToString());
                    }
                }

            }

            return paths;
        }
    }
}
