using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC144
    {
        /// <summary>
        /// 前序遍历方式：根节点->左子树->右子树
        /// 递归算法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null)
                return list;
            IList<int> left = PreorderTraversal(root.left);
            IList<int> right = PreorderTraversal(root.right);

            //根
            list.Add(root.val);

            //左
            foreach (var item in left)
            {
                list.Add(item);
            }
            //右
            foreach (var item in right)
            {
                list.Add(item);
            }

            return list;
        }


        public IList<int> PreorderTraversal1(TreeNode root)
        {
            return null;
        }



    }
}
