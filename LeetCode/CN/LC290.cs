using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC290
    {
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<string, char> s2c = new Dictionary<string, char>();
            Dictionary<char, string> c2s = new Dictionary<char, string>();
            string[] words = s.Split(' ');

            if(words.Length != pattern.Length)
            {
                return false;
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];
                string tmp = words[i];
                if (c2s.ContainsKey(c) && tmp != c2s[c])
                {
                    return false;
                }

                if (s2c.ContainsKey(tmp) && s2c[tmp] != c)
                {
                    return false;
                }

                if (!c2s.ContainsKey(c))
                {
                    c2s.Add(c, tmp);
                }

                if (!s2c.ContainsKey(tmp))
                {
                    s2c.Add(tmp, c);
                }
            }

            return true;
        }
    }
}
