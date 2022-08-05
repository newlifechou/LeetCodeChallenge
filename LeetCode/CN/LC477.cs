using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC477
    {
        public int TotalHammingDistance(int[] nums)
        {
            int ans = 0;
            int n = nums.Length;
            for (int i = 0; i < 30; i++)
            {
                int c = 0;
                //统计i位上有多少个1，即c值
                foreach (var val in nums)
                {
                    c += (val >> i) & 1;
                }
                ans += c * (n - c);
            }
            return ans;
        }
    }
}
