using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1004
    {
        /// <summary>
        /// 二分法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int LongestOnes(int[] nums, int k)
        {
            int n = nums.Length;
            int[] P = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                P[i] = P[i - 1] + (1 - nums[i - 1]);
            }

            int ans = 0;
            int right = 0;
            while (right < n)
            {
                int left = BinarySearch(P, P[right + 1] - k);
                ans = Math.Max(ans, right - left + 1);
                right++;
            }

            return ans;
        }
        private int BinarySearch(int[] P, int target)
        {
            int low = 0, high = P.Length - 1;
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                if (P[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }

        /// <summary>
        /// 滑动窗口
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int LongestOnes2(int[] nums, int k)
        {
            int n = nums.Length;
            int left = 0, right = 0, lsum = 0, rsum = 0;
            int ans = 0;
            while (right < n)
            {
                rsum += 1 - nums[right];
                while (lsum<rsum-k)
                {
                    lsum += 1 - nums[left];
                    left++;
                }
                ans=Math.Max(ans, right - left + 1);
                right++;
            }
            return ans;
        }

    }
}
