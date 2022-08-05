using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC424
    {
        public int CharacterReplacement(string s, int k)
        {
            if(s == null)
                return 0;

            int[] map = new int[26];

            int left = 0, right = 0, historyCharMax = 0;
            while (right<s.Length)
            {
                int index = s[right] - 'A';
                map[index]++;
                historyCharMax = Math.Max(historyCharMax, map[index]);
                if (right - left + 1 > historyCharMax + k)
                {
                    map[s[left] - 'A']--;
                    left++;
                }
                right++;
            }
            return s.Length - left;
        }
    }
}
