using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC034
    {
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] SearchRange(int[] nums, int target)
        {
            int[] range = new int[2];
            range[0] = First_Position(nums, target);
            range[1] = Last_Position(nums, target);
            return range;
        }

        private int First_Position(int[] nums,int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    if (mid == 0 || nums[mid - 1] < target)
                    {
                        return mid;
                    }
                    right = mid - 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }

            }
            return -1;
        }

        private int Last_Position(int[] nums,int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left<=right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    if (mid == nums.Length - 1 || nums[mid + 1] > target)
                    {
                        return mid;
                    }
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
