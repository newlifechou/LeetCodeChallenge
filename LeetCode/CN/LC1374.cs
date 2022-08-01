using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1374
    {
        string generateTheString(int n)
        {
            if (n % 2 == 1)
            {
                return new string('a', n);
            }
            else
            {
                return new string('a', n - 1) + "b";
            }
        }
    }
}
