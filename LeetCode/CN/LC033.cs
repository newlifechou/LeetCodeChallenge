using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC033
    {
        /// <summary>
        /// 将数组一分为二，其中一定有一个是有序的，另一个可能是有序，也能是部分有序。
        /// 此时有序部分用二分法查找。无序部分再一分为二，其中一个一定有序，另一个可能有序，可能无序。就这样循环.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
                return -1;
            if (nums.Length == 1)
                return nums[0] == target ? 0 : -1;

            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[0] <= nums[mid])
                {
                    if (nums[0] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    //判断中间值和target大小且target和尾值的大小
                    if (nums[mid] < target && target <= nums[nums.Length - 1])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
