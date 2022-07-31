using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC171
    {
        public int TitleToNumber(string columnTitle)
        {
            int ans = 0;
            int ratio = 1;
            foreach (var item in columnTitle.Reverse())
            {
                int tailNumber = item - 'A' + 1;
                ans += tailNumber * ratio;
                ratio *= 26;
            }

            return ans;
        }
    }
}
