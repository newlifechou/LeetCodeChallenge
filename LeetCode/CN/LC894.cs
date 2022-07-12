using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC894
    {
        /// <summary>
        /// 所有可能的真二叉树
        /// 满二叉树一定是真二叉树，但反之不一定
        /// 真二叉树每个节点只有0个或者2个子节点
        /// 递归关系
        /// F(N)=F(i)+F(N-1-i),i奇数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<TreeNode> AllPossibleFBT(int n)
        {
            List<TreeNode> list = new List<TreeNode>();

            //真二叉树节点数只可能是奇数1,3,5,7
            if (n % 2 == 0)
                return list;
            //递归终止条件
            if (n == 1)
            {
                TreeNode head = new TreeNode(0);
                list.Add(head);
                return list;
            }
            //所有奇数
            for (int i = 1; i < n; i += 2)
            {
                IList<TreeNode> left = AllPossibleFBT(i);
                IList<TreeNode> right = AllPossibleFBT(n - 1 - i);

                foreach (var left_node in left)
                {
                    foreach (var right_node in right)
                    {
                        TreeNode head = new TreeNode(0);
                        head.left = left_node;
                        head.right = right_node;
                        list.Add(head);
                    }
                }
            }

            return list;
        }
    }
}
