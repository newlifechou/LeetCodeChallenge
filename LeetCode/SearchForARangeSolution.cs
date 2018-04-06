using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-34
    /// </summary>
    public class SearchForARangeSolution
    {
        /// <summary>
        /// 思路
        /// 二分法查找
        /// 先找左边界，当mid==target的时候，right移动到mid，继续找
        /// 同理右边界
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2] { -1, -1 };

            if (nums == null || nums.Length == 0)
                return result;

            int left, mid, right;

            //找到最左
            left = 0;
            right = nums.Length - 1;


            while (left + 1 < right)
            {
                mid = left + (right - left) / 2;
                //如果mid的值大于等于target，继续往左找
                if (nums[mid] >= target)
                {
                    right = mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid;
                }
            }

            //判断lelft还是right
            if (nums[left] == target)
            {
                result[0] = left;
            }
            else if (nums[right] == target)
            {
                result[0] = right;
            }
            else
            {
                result[0] = result[1] = -1;
                return result;
            }

            //找到最右
            left = 0;
            right = nums.Length - 1;

            while (left + 1 < right)
            {
                mid = left + (right - left) / 2;
                if (nums[mid] <= target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }


            if (nums[right] == target)
            {
                result[1] = right;
            }
            else if (nums[left] == target)
            {
                result[1] = left;
            }
            else
            {
                result[0] = result[1] = -1;
                return result;
            }


            return result;
        }
    }
}
