using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC198
    {
        public int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
                return 0;
            if (n == 1)
                return nums[0];
            //第i个最大收益
            int[] values = new int[n];
            values[0] = nums[0];
            values[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < n; i++)
            {
                values[i] = Math.Max(values[i - 1], values[i - 2] + nums[i]);
            }

            return values[n - 1];
        }
    }
}
