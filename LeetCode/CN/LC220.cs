using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC220
    {
        /// <summary>
        /// 滑动窗口
        /// 位置i(u)，在i-k,i找到u-t,u+t
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            //类似java的treeset
            SortedSet<long> ss = new SortedSet<long>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (ss.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count > 0)
                {
                    return true;
                }

                ss.Add(nums[i]);
                if (ss.Count > k)
                {
                    ss.Remove(nums[i - k]);
                }

            }
            return false;
        }

        /// <summary>
        /// 桶排序
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool ContainsNearbyAlmostDuplicate2(int[] nums, int k, int t)
        {




            return false;
        }

    }
}
