using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC053
    {
        //最大子数组和
        //动态规划方法
        public int MaxSubArray(int[] nums)
        {
            int[] dp = new int[nums.Length + 1];
            int result = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i + 1] = Math.Max(dp[i] + nums[i], nums[i]);
                result = Math.Max(dp[i + 1], result);
            }

            return result;
        }



        //最大子数组和
        //进阶，分治法
        public int MaxSubArray2(int[] nums)
        {
            return 0;
        }
    }
}
