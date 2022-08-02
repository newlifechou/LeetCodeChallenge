using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Helper(nums, 0, nums.Length - 1);
        }

        private TreeNode Helper(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            //总是选择中间位置左边的数字作为根节点
            int mid = (left + right) / 2;
            //总是选择中间位置右边的数字作为根节点
            //int mid = (left + right+1) / 2;

            TreeNode root = new TreeNode(nums[mid]);
            root.left = Helper(nums, left, mid - 1);
            root.right = Helper(nums, mid + 1, right);

            return root;
        }

    }
}
