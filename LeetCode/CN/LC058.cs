using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC058
    {
        public int LengthOfLastWord(string s)
        {
            int end = s.Length - 1;
            while (end >= 0 && s[end]==' ')
            {
                end--;
            }

            if (end < 0)
                return 0;
            int start = end;

            while (start >= 0 && s[start]!=' ')
            {
                start--;
            }

            return end - start;

        }
    }
}
