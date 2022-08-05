using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC594
    {
        public int FindLHS1(int[] nums)
        {
            Array.Sort(nums);
            int begin = 0;
            int res = 0;
            for (int end = 0; end < nums.Length; end++)
            {
                while (nums[end] - nums[begin]>1)
                {
                    begin++;
                }
                if (nums[end] - nums[begin] == 1)
                {
                    res = Math.Max(res, end - begin + 1);
                }
            }

            return res;

        }

        /// <summary>
        /// hashtable
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindLHS2(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int res = 0;
            foreach (var num in nums)
            {
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                {
                    result.Add(num, 1);
                }
            }

            foreach (var key in result.Keys)
            {
                if (result.ContainsKey(key + 1))
                {
                    res = Math.Max(res, result[key] + result[key + 1]);
                }
            }

            return res;
        }


    }
}
