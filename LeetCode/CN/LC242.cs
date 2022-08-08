using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 异位词
    /// 字母一样，顺序不同
    /// </summary>
    public class LC242
    {
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram1(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            char[] ss = s.ToCharArray();
            char[] tt = t.ToCharArray();
            Array.Sort(ss);
            Array.Sort(tt);

            return ss.SequenceEqual(tt);
        }

        /// <summary>
        /// 哈希
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] table = new int[26];
            foreach (var item in s)
            {
                table[item - 'a']++;
            }
            foreach (var item in t)
            {
                table[item - 'a']--;
                if (table[item - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
