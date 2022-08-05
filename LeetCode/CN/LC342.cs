using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC342
    {
        public bool IsPowerOfFour(int n)
        {
            if(n<=0)
                return false;
            int x = (int)Math.Sqrt(n);
            return x * x == n && (x & (x - 1)) == 0;
        }
    }
}
