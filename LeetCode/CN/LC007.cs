using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 整数反转
    /// </summary>
    internal class LC007
    {
        /// <summary>
        /// 字符串反转或者用栈并不好
        /// 拿到整数末尾数字
        /// %10取末尾，/10去除末尾
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Reverse(int x)
        {
            int res = 0;

            //减少一位的最大最小值
            int max_1 = int.MaxValue / 10;
            int min_1 = int.MinValue / 10;
            while (x != 0)
            {
                //取尾数
                int tmp = x % 10;

                //考虑特殊情况,提前判断
                if (res > max_1 || (res == max_1 && tmp > 7))
                {
                    return 0;
                }

                if (res < min_1 || (res == min_1 && tmp < -8))
                {
                    return 0;
                }


                //已取到的数向左挪动一位给tmp留空位
                res = res * 10 + tmp;
                //去掉尾数减少一位
                x /= 10;
            }

            return res;
        }
    }
}
