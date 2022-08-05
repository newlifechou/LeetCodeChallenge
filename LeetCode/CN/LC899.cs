using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC899
    {
        public string OrderlyQueue(string s, int k)
        {
            if(k==1)
            {
                string smallest = s;
                StringBuilder sb = new StringBuilder(s);
                for (int i = 0; i < s.Length; i++)
                {
                    char c = sb[0];
                    sb.Remove(0, 1);
                    sb.Append(c);
                    if(sb.ToString().CompareTo(smallest) < 0)
                    {
                        smallest = sb.ToString();
                    }
                }
                return smallest;
            }
            else
            {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
        }
    }
}
