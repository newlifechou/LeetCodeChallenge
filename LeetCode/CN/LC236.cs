using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{

    public class LC236
    {
        /// <summary>
        /// 二叉树的最近公共祖先
        /// 对于有根树 T 的两个节点 p、q，最近公共祖先表示为一个节点 x，满足 x 是 p、q 的祖先且 x 的深度尽可能大（一个节点也可以是它自己的祖先）。
        /// 
        /// DFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            //递归终止条件
            if (root == null)
                return root;

            if (root == p || root == q)
                return root;

            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
            {
                return root;
            }
            else if (left != null)
            {
                return left;
            }
            else if (right != null)
            {
                return right;
            }
            else
            {
                return null;
            }


        }
        /// <summary>
        /// 存储父节点
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            Dfs(root);
            while (p!=null)
            {
                visited.Add(p.val);
                p = parents[p.val];
            }

            while (q!=null)
            {
                if (visited.Contains(q.val))
                    return q;
                q = parents[q.val];
            }
            return null;
        }

        private void Dfs(TreeNode root)
        {
            if (root.left != null)
            {
                parents.Add(root.left.val, root);
                Dfs(root.left);
            }
            if (root.right != null)
            {
                parents.Add(root.right.val, root);
                Dfs(root.right);
            }
        }
        private Dictionary<int, TreeNode> parents = new Dictionary<int, TreeNode>();
        private HashSet<int> visited = new HashSet<int>();

    }
}
