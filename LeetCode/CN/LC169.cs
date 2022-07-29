using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC169
    {
        /// <summary>
        /// hasttable统计
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement1(int[] nums)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item, 1);
                }
            }

            int key = 0, maxValue = 0;
            foreach (var item in counter)
            {
                if (item.Value > maxValue)
                {
                    maxValue = item.Value;
                    key= item.Key;
                }
            }

            return key;
        }

        /// <summary>
        /// 排序
        /// 取中间
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement2(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }

        /// <summary>
        /// 摩尔投票法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement3(int[] nums)
        {
            int majority = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if(count==0)
                {
                    count++;
                    majority = nums[i];
                }
                else if (majority == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return majority;
        }

    }
}
