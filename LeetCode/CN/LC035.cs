using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC035
    {
        /// <summary>
        /// 二分查找
        /// nums[pos-1] < target <= nums[pos] 
        /// 在一个有序数组中找第一个大于等于 target 的下标
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int n = nums.Length;
            int left = 0, right = n - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;//(left+right)/2
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}
