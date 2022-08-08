using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC235
    {
        public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            List<TreeNode> path_p = GetPath(root, p);
            List<TreeNode> path_q = GetPath(root, q);
            TreeNode ancestor = null;
            for (int i = 0; i < path_p.Count && i < path_q.Count; i++)
            {
                if (path_p[i] == path_q[i])
                {
                    ancestor = path_p[i];
                }
                else
                {
                    break;
                }
            }
            return ancestor;
        }
        private List<TreeNode> GetPath(TreeNode root, TreeNode target)
        {
            List<TreeNode> path = new List<TreeNode>();
            TreeNode node = root;
            while (node != target)
            {
                path.Add(node);
                if (target.val < node.val)
                {
                    node = node.left;
                }
                else
                {
                    node = node.right;
                }
            }
            path.Add(node);
            return path;
        }

        public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode ancestor = root;
            while (true)
            {
                if (p.val < ancestor.val && q.val < ancestor.val)
                {
                    ancestor = ancestor.left;
                }
                else if (p.val > ancestor.val && q.val > ancestor.val)
                {
                    ancestor = ancestor.right;
                }
                else
                {
                    break;
                }
            }
            return ancestor;
        }
    }
}
