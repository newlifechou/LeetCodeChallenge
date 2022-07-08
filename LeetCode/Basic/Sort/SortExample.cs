using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN.Sort
{
    public class SortExample
    {
        public void Sort(int[] nums)
        {

        }

        private bool Less(int a,int b)
        {
            return a < b;
        }

        private void Show(int[] nums)
        {
            foreach (var num in nums)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }

        public bool IsSorted(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (Less(nums[i], nums[i - 1]))
                    return false;
            }
            return true;
        }

    }
}
