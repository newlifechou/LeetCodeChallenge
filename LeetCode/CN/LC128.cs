using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC128
    {
        /// <summary>
        /// 最长连续序列
        /// 未排序，数字连续的最长序列
        /// 时间复杂度O(n)
        /// 利用hashset存储所有元素，然后查询当前元素左右两边序列数字是否存在
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;


            HashSet<int> set = new HashSet<int>();
            //存入hashset
            foreach (var num in nums)
            {
                set.Add(num);
            }

            //查询当前元素左右两边序列数字是否存在，存在计数
            int result = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                //如果有效的，让小的先来
                if (!set.Contains(num - 1))
                {
                    while (set.Contains(num))
                    {
                        count++;
                        num++;
                    }
                    result = Math.Max(result, count);
                    count = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// 排序后，针对相同跳过，前后差值1则计数加1，否则置零
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutive1(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            Array.Sort(nums);
            int maxLength = 0, len = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                maxLength = Math.Max(maxLength, len);

                if (nums[i] - nums[i - 1] == 1)
                {
                    len++;
                }
                else if (nums[i] - nums[i - 1] == 0)
                {
                    continue;
                }
                else
                {
                    len = 1;
                }

            }

            return Math.Max(maxLength, len);
        }



    }
}
