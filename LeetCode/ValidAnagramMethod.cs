using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// LeetCode-242
    /// </summary>
    public class ValidAnagramMethod
    {
        /// <summary>
        /// 基本思路
        /// 统计每个字符串中的字母，然后对比看包含的字母是否相等
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s,string t)
        {
            int[] stat_s = new int[26];
            int[] stat_t = new int[26];
            int length_s = s.Length;
            int length_t = t.Length;
            //统计s
            for (int i = 0; i < length_s; i++)
            {
                //利用ascii相减得到下标
                int index = s[i] - 'a';
                stat_s[index]++;
            }
            //统计t
            for (int i = 0; i < length_t; i++)
            {
                //利用ascii相减得到下标
                int index = t[i] - 'a';
                stat_t[index]++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (stat_s[i] != stat_t[i])
                    return false;
            }
            return true;
        }
    }
}
