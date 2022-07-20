using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC026
    {
        /// <summary>
        /// 有序数组，重复元素一定相邻
        /// 将不重复的元素移动到左边
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int p = 0, q = 1;
            while (q<nums.Length)
            {
                if (nums[p] != nums[q])
                {
                    nums[p + 1] = nums[q];
                    p++;
                }
                q++;
            }
            return p + 1;

        }
    }
}
