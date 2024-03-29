﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC689
    {

        /// <summary>
        /// 三个无重叠数组的最大和
        /// 滑动窗口方法
        /// https://leetcode.cn/problems/maximum-sum-of-3-non-overlapping-subarrays/solution/san-ge-wu-zhong-die-zi-shu-zu-de-zui-da-4a8lb/
        /// 官方标准解法
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
        {
            int[] ans = new int[3];
            int sum1 = 0, maxSum1 = 0, maxSum1Idx = 0;
            int sum2=0,maxSum12=0,maxsum12Idx1=0,maxsum12Idx2=0;
            int sum3 = 0, maxTotal = 0;

            for (int i = k*2; i < nums.Length; i++)
            {
                sum1 += nums[i - k * 2];
                sum2 += nums[i - k];
                sum3 += nums[i];
                if (i >= k * 3 - 1)
                {
                    if (sum1 > maxSum1)
                    {
                        maxSum1 = sum1;
                        maxSum1Idx = i - k * 3 + 1;
                    }

                    if (maxSum1 + sum2 > maxSum12)
                    {
                        maxSum12 = maxSum1 + sum2;
                        maxsum12Idx1 = maxSum1Idx;
                        maxsum12Idx2 = i - k * 2 + 1;
                    }

                    if (maxSum12 + sum3 > maxTotal)
                    {
                        maxTotal = maxSum12 + sum3;
                        ans[0] = maxsum12Idx1;
                        ans[1] = maxsum12Idx2;
                        ans[2] = i - k + 1;
                    }

                    //滑动
                    sum1 -= nums[i - k * 3 + 1];
                    sum2 -= nums[i - k * 2 + 1];
                    sum3 -= nums[i - k + 1];
                }


            }


            return ans;

        }


        /// <summary>
        /// 动态规划方法 later
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSumOfThreeSubarrays2(int[] nums, int k)
        {
            return null;
        }
        //采用动态规划求解，状态转移方程：dp[2][n] = max(dp[2][n-1], dp[1][n-k] + sumRange(n, n -k+1))。其中一维长度为3，表示三个子数组。
    }
}
