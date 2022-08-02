using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC095
    {
        /// <summary>
        /// 二叉搜索树关键的性质是根节点的值大于左子树所有节点的值，
        /// 小于右子树所有节点的值，且左子树和右子树也同样为二叉搜索树。
        /// i为root,left=[1,i-1],right=[i+1,n]
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
                return new List<TreeNode>();
            return Generate(1, n);
        }

        private List<TreeNode> Generate(int start, int end)
        {
            List<TreeNode> trees = new List<TreeNode>();
            if (start > end)
            {
                trees.Add(null);
                return trees;
            }

            for (int i = start; i <= end; i++)
            {
                //分别获取所有可行的左子树和右子树
                List<TreeNode> leftTress = Generate(start, i - 1);
                List<TreeNode> rightTrees = Generate(i + 1, end);

                //左右子树连接到根
                foreach (var left in leftTress)
                {
                    foreach (var right in rightTrees)
                    {
                        TreeNode currentTree = new TreeNode(i);
                        currentTree.left = left;
                        currentTree.right = right;
                        trees.Add(currentTree);
                    }
                }
            }

            return trees;
        }

    }
}
