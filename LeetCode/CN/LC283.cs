using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 移动零
    /// </summary>
    public class LC283
    {
        /// <summary>
        /// 依然双指针
        /// left已处理好的尾部
        /// right待处理的头部
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            int n = nums.Length;
            int l = 0, r = 0;
            while (r<n)
            {
                if (nums[r] != 0)
                {
                    int tmp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = tmp;
                    l++;
                }
                r++;
            }
        }
    }
}
