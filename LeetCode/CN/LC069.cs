using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC069
    {
        /// <summary>
        /// 利用指数和对数间接计算
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt1(int x)
        {
            if (x == 0)
                return 0;
            int ans = (int)Math.Exp(0.5 * Math.Log(x));
            return (long)(ans + 1) * (ans + 1) <= x ? ans + 1 : ans;
        }

        /// <summary>
        /// 二分法找出来
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt2(int x)
        {
            int left = 0, right = x, ans = -1;
            while (left<=right)
            {
                int mid = left + (right - left) / 2;
                if ((long)mid * mid <= x)
                {
                    ans = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return ans;
        }


        /// <summary>
        /// 牛顿迭代法
        /// 本质是借助泰勒级数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt3(int x)
        {
            s = x;
            if (x == 0)
                return 0;
            return (int)Sqrts(x);
        }

        private int s;
        private double Sqrts(double x)
        {
            double res = (x + s / x) / 2;
            if (res == x)
                return x;
            else
                return Sqrts(res);
        }

    }
}
