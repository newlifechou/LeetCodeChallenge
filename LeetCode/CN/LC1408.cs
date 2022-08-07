using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1408
    {
        public IList<string> StringMatching(string[] words)
        {
            List<string> ans = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (words[j].IndexOf(words[i]) >= 0)
                    {
                        ans.Add(words[i]);
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
