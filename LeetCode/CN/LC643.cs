using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC643
    {
        /// <summary>
        /// slide window
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            int maxSum = sum;
            
            //继续滑动
            for (int i = k; i < nums.Length; i++)
            {
                sum = sum - nums[i - k] + nums[i];
                maxSum = Math.Max(maxSum, sum);
            }

            return 1.0 * maxSum / k;
        }
    }
}
