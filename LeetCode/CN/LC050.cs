using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC050
    {
        /// <summary>
        /// 快速幂+递归
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double MyPow(double x, int n)
        {
            return n >= 0 ? Quick(x, n) : 1.0 / Quick(x, -n);
        }

        private double Quick(double x,int n)
        {
            if (n == 0)
                return 1.0;

            double y = Quick(x, n / 2);
            return n % 2 == 0 ? y * y : y * y * x;
        }
    }
}
