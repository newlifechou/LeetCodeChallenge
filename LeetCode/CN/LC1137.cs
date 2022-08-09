﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1137
    {
        public int Tribonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n <= 2)
                return 1;

            int p = 0, q = 0, r = 1, s = 1;
            for (int i = 3; i <= n; i++)
            {
                p = q;
                q = r;
                r = s;
                s = p + q + r;
            }
            return s;
        }
    }
}
