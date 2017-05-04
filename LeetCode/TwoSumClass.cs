using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeetCode
{
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] results = new int[2] { 0, 0 };
            int sum = 0;
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        results[0] = i;
                        results[1] = j;
                        return results;
                    }
                }
            }
            return results;
        }
    }
}
