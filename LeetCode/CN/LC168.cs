using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC168
    {
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder ans = new StringBuilder();

            while (columnNumber > 0)
            {
                columnNumber--;
                int tailNumber = columnNumber % 26;
                char ch = (char)('A' + tailNumber);
                ans.Insert(0, ch);
                columnNumber /= 26;
            }

            return ans.ToString();
        }
    }
}
