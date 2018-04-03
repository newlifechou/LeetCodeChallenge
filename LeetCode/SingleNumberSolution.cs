using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-136
    /// </summary>
    public class SingleNumberSolution
    {
        /// <summary>
        /// 思路
        /// 最简单的思路
        /// 统计法
        /// 算法太暴力O(n*n)，对于大数组运行时间太长
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int readyNumber = nums[i];
                int count = Count(nums, readyNumber);
                if (count == 1)
                    return readyNumber;
            }
            return 0;
        }

        private int Count(int[] nums, int k)
        {
            int c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == k)
                {
                    c++;
                }
            }
            return c;
        }

        /// <summary>
        /// XOR操作的一个性质
        /// a^b^a=b
        /// 相同数字项会被抵消掉
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber2(int[] nums)
        {
            int k = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                k = k ^ nums[i];
            }
            return k;
        }



    }
}
