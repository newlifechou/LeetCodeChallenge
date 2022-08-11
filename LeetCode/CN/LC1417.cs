using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1417
    {
        public string Reformat(string s)
        {
            int countDigit = 0, countAlpha = 0;
            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    countDigit++;
                }
                else if (char.IsLetter(c))
                {
                    countAlpha++;
                }
            }

            if (Math.Abs(countAlpha - countDigit) > 1)
            {
                return "";
            }

            bool flag = countDigit > countAlpha;

            var ss = s.ToCharArray();

            for (int i = 0, j = 1; i < ss.Length; i += 2)
            {
                //不是数字的话，交换
                if (char.IsDigit(ss[i]) != flag)
                {
                    while (char.IsDigit(ss[j]) != flag)
                    {
                        j += 2;
                    }
                    Swap(ss, i, j);
                }
            }

            return new string(ss);
        }

        private void Swap(char[] ss, int i, int j)
        {
            char c = ss[i];
            ss[i] = ss[j];
            ss[j] = c;
        }

    }
}
