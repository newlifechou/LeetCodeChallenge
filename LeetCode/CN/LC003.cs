using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC003
    {
        /// <summary>
        /// 滑动窗口
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int ans = 0;

            //value=char位置+1，表示字符位置下一个才开始不重复
            Dictionary<char, int> map = new Dictionary<char, int>();

            //不重复子串的开始和结束位置
            int start = 0, end = 0;

            while (end<n)
            {
                char a = s[end];
                if (map.ContainsKey(a))
                {
                    start = Math.Max(map[a], start);
                }
                ans = Math.Max(ans, end - start + 1);
                map[s[end]] = end + 1;
                end++;
            }
            return ans;
        }
    }
}
