using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC219
    {
        /// <summary>
        /// 滑动窗口
        /// 是否存在长度不超过的 k+1 窗口，窗口内有相同元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > k)
                {
                    set.Remove(nums[i - k - 1]);
                }

                if (set.Contains(nums[i]))
                    return true;
                
                set.Add(nums[i]);
            }
            return false;
        }
    }
}
