using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class ThreeSum
    {
        /// <summary>
        /// 统计和为0的threesum的所有元组数量
        /// 暴力方法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Count(int[] nums)
        {
            int N = nums.Length;
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    for (int k = j+1; k < N; k++)
                    {
                        if (nums[i] + nums[j] + nums[k]==0)
                            cnt++;
                    }
                }
            }


            return cnt;
        }



    }
}
