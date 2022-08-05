using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC992
    {
        /// <summary>
        /// k个不同的数字组成子数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            int n = nums.Length;
            //存储每个位置的p
            int[] lower = new int[n];
            //存储每个位置的j
            int[] upper = new int[n];

            Find(lower, nums, k);
            Find(upper, nums, k - 1);

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                //累加每次以nums[i]为右
                ans += upper[i] - lower[i];
            }
            return ans;
        }

        private void Find(int[] arr, int[] nums, int k)
        {
            int n = arr.Length;
            int[] cnt = new int[n + 1];
            //左右游标
            int i = 0, j = 0, sum = 0;
            while (i < n)
            {
                int right = nums[i];
                if (cnt[right] == 0)
                    sum++;
                cnt[right]++;
                while (sum > k)
                {
                    int left = nums[j];
                    j++;
                    cnt[left]--;
                    if (cnt[left] == 0)
                    {
                        sum--;
                    }
                }
                arr[i] = j;
                i++;
            }
        }


    }
}
