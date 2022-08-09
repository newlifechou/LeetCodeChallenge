using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC326
    {
        public bool IsPowerOfThree1(int n)
        {
            if (n <= 0)
                return false;
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }


        public bool IsPowerOfThree2(int n)
        {
            int max = (int)Math.Pow(3, 19);
            return n > 0 && max % 3 == 0;
        }


    }
}
