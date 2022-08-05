using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC030
    {
        /// <summary>
        /// 使用map存储words中的单词数目
        /// 不断取m*w长度的子串
        /// 使用新map来统计子串中单词出现的次数
        /// 比较两个map是否一样
        /// </summary>
        /// <param name="s"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public IList<int> FindSubstring(string s, string[] words)
        {

            int n = s.Length, m = words.Length, w = words[0].Length;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word]++;
                }
            }

            List<int> ans = new List<int>();

            for (int i = 0; i <= n - m * w; i++)
            {
                //得到一个m*w长度的子串，统计该子串
                string sub = s.Substring(i, m * w);
                Dictionary<string, int> cur = new Dictionary<string, int>();
                for (int j = 0; j < sub.Length; j += w)
                {
                    string item = sub.Substring(j, w);
                    if (!dict.ContainsKey(item))
                        continue;
                    else
                    {
                        if (!cur.ContainsKey(item))
                        {
                            cur.Add(item, 1);
                        }
                        else
                        {
                            cur[item]++;
                        }
                    }
                }


                bool isSame = true;
                //比较dict和cur的区别
                foreach (var item in dict.Keys)
                {
                    if (!dict.ContainsKey(item) || !cur.ContainsKey(item) || dict[item] != cur[item])
                    {
                        isSame = false;
                        break;
                    }
                }

                if (isSame)
                {
                    ans.Add(i);
                }

            }

            return ans;
        }
    }
}
