using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC769
    {
        /// <summary>
        /// 下标之和=元素之和
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MaxChunksToSorted(int[] arr)
        {
            int ans = 0;
            int sum = 0;
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                total += i;
                if (sum == total)
                {
                    ans++;
                    sum = 0;
                    total = 0;
                }
            }
            return ans;
        }
    }
}
