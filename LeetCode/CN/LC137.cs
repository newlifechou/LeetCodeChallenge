using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC137
    {
        /// <summary>
        /// hashtable
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber1(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return -1;
        }

        /// <summary>
        /// 对int的32位进行位数统计
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber2(int[] nums)
        {
            int[] cnt = new int[32];
            foreach (var item in nums)
            {
                for (int i = 0; i < 32; i++)
                {
                    if (((item >> i) & 1) == 1)
                    {
                        cnt[i]++;
                    }
                }
            }

            int ans = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((cnt[i] % 3 & 1) == 1)
                {
                    ans += (1 << i);
                }
            }

            return ans;

        }

    }
}
