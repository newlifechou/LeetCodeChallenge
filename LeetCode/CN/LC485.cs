using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 最大连续1的个数
    /// </summary>
    public class LC485
    {
       /// <summary>
       /// 一次遍历
       /// </summary>
       /// <param name="nums"></param>
       /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }
            //考虑退出循环的最后一次情况
            maxCount = Math.Max(maxCount, count);
            return maxCount;
        }
    }
}
