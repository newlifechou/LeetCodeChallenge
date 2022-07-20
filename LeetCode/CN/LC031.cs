using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC031
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length <= 1)
                return;

            int n = nums.Length;
            int i = n - 2, j = n - 1, k = n - 1;
            //find A[i]<A[j]
            while (i >= 0 && nums[i] >= nums[j])
            {
                i--;
                j--;
            }

            if (i >= 0)
            {
                //find A[i]<A[k]
                while (nums[i] >= nums[k])
                {
                    k--;
                }
                int temp = nums[i];
                nums[i] = nums[k];
                nums[k] = temp;
            }

            //reverse A[j:end]
            i = j;
            j = n - 1;
            while (i<j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }


        }
    }
}
