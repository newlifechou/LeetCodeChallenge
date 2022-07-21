using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC028
    {
        /// <summary>
        /// 子字符串匹配，暴力或者KMP算法
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int a = i, b = 0;
                while (b < needle.Length && haystack[a] == needle[b])
                {
                    a++;
                    b++;
                }
                if (b == needle.Length)
                    return i;
            }
            return -1;
        }


        /// <summary>
        /// KMP
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;


            int n = haystack.Length, m = needle.Length;

            int[] next = new int[m];
            next[0] = 0;

            int j = 0;
            //获取next数组
            //i从第二个元素开始
            for (int i = 1; i < m; i++)
            {
                while (j > 0 && needle[j] != needle[i])
                {
                    j = next[j - 1];
                }

                if(needle[j] == needle[i])
                {
                    j++;
                }

                next[i] = j;
            }

            j = 0;
            for (int i = 0; i < n; i++)
            {
                while (j > 0 && haystack[i] != needle[j])
                {
                    j = next[j - 1];
                }
                if (haystack[i] == needle[j])
                {
                    j++;
                }

                if (j == m)
                    return i - m + 1;
            }

            return -1;


        }
    }
}
