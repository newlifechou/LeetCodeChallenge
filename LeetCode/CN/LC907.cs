using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC907
    {
        /// <summary>
        /// 子数组的最小之和
        /// 单调栈+动态规划
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int SumSubarrayMins(int[] arr)
        {
            //单调栈
            Stack<int> stack = new Stack<int>();
            //记录动态规划结果
            int[] dp = new int[arr.Length + 1];
            //设置标志
            stack.Push(-1);
            //M取模防止溢出
            int result = 0, M = (int)1e9 + 7;
            for (int i = 0; i < arr.Length; i++)
            {
                //判断单调
                while (stack.Peek() != -1 &&
                    arr[i] <= arr[stack.Peek()])
                {
                    stack.Pop();
                }
                dp[i + 1] = (dp[stack.Peek() + 1] + 
                    (i - stack.Peek()) * arr[i]) % M;
                stack.Push(i);

                result += dp[i + 1];
                result %= M;
            }




            return result;
        }

        /// <summary>
        /// 暴力方法
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int SumSubarrayMins1(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            long MOD = 1000_000_007;
            int n = arr.Length;
            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                int min = arr[i];
                for (int j = i; j < n; j++)
                {
                    min = Math.Min(min, arr[j]);
                    ans = (ans + min) % MOD;
                }
            }

            return (int)ans;
        }


    }
}
