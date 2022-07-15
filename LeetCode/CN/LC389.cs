using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 找不同
    /// </summary>
    internal class LC389
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public char FindTheDifference1(string s, string t)
        {
            int[] cnt = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                cnt[ch - 'a']++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                char ch = t[i];
                cnt[ch - 'a']--;
                if (cnt[ch - 'a'] < 0)
                    return ch;
            }
            return ' ';
        }
        /// <summary>
        /// 对字符串每个字符求和，然后相减，得到就是多出来的字符
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public char FindTheDifference2(string s, string t)
        {
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum1 += s[i];
            }
            for (int i = 0; i < t.Length; i++)
            {
                sum2 += s[i];
            }

            return (char)(sum2 - sum1);
        }
    }
}
