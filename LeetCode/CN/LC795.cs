using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC795
    {
        /// <summary>
        /// 区间子数组个数
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public int NumSubarrayBoundedMax(int[] nums, int left, int right)
        {
            /*  对于某子序列
              if(“包含大于right的数”）
                  该子序列不合题意;
              else
                  if(“只包含小于left的数”)
                      该子序列不满足题意;
                  else
                      该子序列满足题意;
            */
            // 故：“不包含大于right的数”的子序列个数 - “只包含小于left的数”的子序列个数 = 目标子序列数
            // 而：“不包含大于right的数” 等价于 “只包含小于等于right的数”，又等价于“只包含小于right+1的数”
            // 最终：“只包含小于right+1的数”的子序列个数 - “只包含小于left的数”的子序列个数 = 目标子序列数
            return Help(nums, right + 1) - Help(nums, left);
        }

        //求数组中“只包含小于max的数”的子数组的个数
        private int Help(int[] nums, int max)
        {

            int result = 0;
            int numSubArray = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < max)
                {
                    numSubArray++;
                    result += numSubArray;
                }
                else
                {
                    numSubArray = 0;
                }
            }
            return result;
        }

    }
}
