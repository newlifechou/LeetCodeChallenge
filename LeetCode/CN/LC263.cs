using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC263
    {
        public bool IsUgly(int n)
        {
            if (n <= 0)
                return false;

            int[] factors = { 2, 3, 5 };
            foreach (var factor in factors)
            {
                while (n % factor == 0)
                {
                    n /= factor;
                }
            }

            return n == 1;
        }
    }
}
