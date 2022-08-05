using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> s2t = new Dictionary<char, char>();
            Dictionary<char, char> t2s = new Dictionary<char, char>();

            if (s.Length != t.Length)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                char x = s[i], y = t[i];
                if ((s2t.ContainsKey(x) && s2t[x] != y) || t2s.ContainsKey(y) && t2s[y]!=x)
                {
                    return false;
                }
                if (!s2t.ContainsKey(x))
                {
                    s2t.Add(x, y);
                }
                if (!t2s.ContainsKey(y))
                {
                    t2s.Add(y, x);
                }
            }

            return true;
        }
    }
}
