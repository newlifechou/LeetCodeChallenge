using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1984
    {
        /// <summary>
        /// 排序后，滑动窗口
        /// 所有nums[i+k-1]-nums[i]的值的最小值
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MinimumDifference(int[] nums, int k)
        {
            Array.Sort(nums);
            int ans = int.MaxValue;

            int i = 0;
            while (i + k - 1 < nums.Length)
            {
                ans = Math.Min(ans, nums[i + k - 1] - nums[i]);
                i++;
            }
            return ans;
        }
    }
}
