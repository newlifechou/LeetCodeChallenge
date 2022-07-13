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
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int SumSubarrayMins(int[] arr)
        {
            if (arr = null || arr.Length == 0)
                return 0;

            long res = 0;
            long mod = 1000_000_007;



            return 0;

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
