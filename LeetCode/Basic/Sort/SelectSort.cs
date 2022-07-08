using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN.Sort
{
    public class SelectSort
    {
        public static void Sort(int[] nums)
        {
            int N = nums.Length;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

        }
    }
}
