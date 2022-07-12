using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC145
    {
        /// <summary>
        /// 二叉树后续遍历
        /// 左-右-根
        /// 迭代方法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null)
                return list;

            IList<int> left = PostorderTraversal(root.left);
            IList<int> right = PostorderTraversal(root.right);

            foreach (var item in left)
            {
                list.Add(item);
            }
    
            foreach (var item in right)
            {
                list.Add(item);
            }

            list.Add(root.val);

            return list;
        }
    }
}
