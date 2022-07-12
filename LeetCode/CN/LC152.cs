using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC152
    {
        /// <summary>
        /// 乘积最大子数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxProduct(int[] nums)
        {
            int result = nums[0];
            int n_max = 1;
            int n_min = 1;

            foreach (var num in nums)
            {
                if (num < 0)
                {
                    //如果乘数是负，需要乘以最大值再作为最小值
                    //同理，最小值乘以后作为新的最大值
                    int temp = n_max;
                    n_max = Math.Max(n_min * num, num);
                    n_min = Math.Min(temp * num, num);
                }
                else
                {
                    n_max = Math.Max(n_max * num, num);
                    n_min = Math.Min(n_min * num, num);
                }

                result = Math.Max(n_max, result);
            }

            return result;
        }
    }
}
