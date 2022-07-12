using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC094
    {
        /// <summary>
        /// 二叉树中序遍历
        /// 左-根-右
        /// 递归算法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null)
                return list;

            IList<int> left = InorderTraversal(root.left);
            IList<int> right = InorderTraversal(root.right);

            foreach (var item in left)
            {
                list.Add(item);
            }

            list.Add(root.val);

            foreach (var item in right)
            {
                list.Add(item);
            }
            return list;
        }

    }
}
