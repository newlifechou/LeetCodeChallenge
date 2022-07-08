using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class Search
    {
        public int rank(int key, int[] nums)
        {
            return rank(key, nums, 0, nums.Length - 1);
        }

        public int rank(int key, int[] nums, int lo, int hi)
        {
            if (lo > hi)
                return -1;
            int mid = lo + (hi - lo) / 2;
            if (key < nums[mid])
                return rank(key, nums, lo, mid - 1);
            else if (key > nums[mid])
                return rank(key, nums, mid + 1, hi);
            else
                return mid;
        }
    }
}
