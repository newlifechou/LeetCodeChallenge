using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN.Sort
{
    public class InsertSort
    {
        public static void Sort(int[] nums)
        {
            int N = nums.Length;
            for (int i = 1; i < N; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if(nums[j] > nums[j-1])
                    {
                        int temp=nums[j-1];
                        nums[j - 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }



        }



    }
}
