using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 
    /// </summary>
    public class LC187
    {
        /// <summary>
        /// hashset
        /// 统计所有长度为10子串出现的次数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<string> FindRepeatedDnaSequences1(string s)
        {
            IList<string> ans = new List<string>();
            Dictionary<string, int> cnt = new Dictionary<string, int>();
            int n = s.Length;
            const int L = 10;
            for (int i = 0; i <= n - L; i++)
            {
                string sub = s.Substring(i, L);
                if (!cnt.ContainsKey(sub))
                {
                    cnt.Add(sub, 1);
                }
                else
                {
                    cnt[sub]++;
                }

                if (cnt[sub] == 2)
                {
                    ans.Add(sub);
                }
            }

            return ans;
        }

        /// <summary>
        /// hashset+slidewindow+bit calculation
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<string> FindRepeatedDnaSequences2(string s)
        {
            return null;
        }
    }
}
