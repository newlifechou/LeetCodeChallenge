using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC110
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            else
            {
                return Math.Abs(Height(root.left) - Height(root.right)) <= 1 &&
                    IsBalanced(root.left) && IsBalanced(root.right);
            }
        }

        private int Height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(Height(root.left), Height(root.right)) + 1;
            }
        }

    }
}
