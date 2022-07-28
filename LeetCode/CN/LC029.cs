using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC029
    {
        public int Divide(int dividend, int divisor)
        {
            long x = dividend, y = divisor;
            bool isNegative = false;
            if ((x > 0 && y < 0) || (x < 0 && y > 0))
            {
                isNegative = true;
            }
            if (x < 0) x = -x;
            if (y < 0) y = -y;


            //二分法
            long left = 0, right = x;
            while (left < right)
            {
                long mid = (left + right + 1) / 2;
                if (Mul(mid, y) <= x)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            long ans = isNegative ? -left : left;
            if (ans > int.MaxValue || ans < int.MinValue)
                return int.MaxValue;
            return (int)ans;
        }

        /// <summary>
        /// 快速乘法
        /// 倍增思想
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="k">k</param>
        /// <returns></returns>
        private long Mul(long a, long k)
        {
            long ans = 0;
            while (k > 0)
            {
                if ((k & 1) == 1)//判断奇偶
                    ans += a;
                k >>= 1;//除以2
                a += a;
            }

            return ans;
        }





    }
}
