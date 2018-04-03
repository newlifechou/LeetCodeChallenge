using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-7
    /// </summary>
    public class ReverseIntegerSolution
    {
        //假定只考虑32位符号数，溢出返回0

        /// <summary>
        /// 思路
        /// 不断模10
        /// 得到最后一位，然后重新通过x10来构造新数字
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Reverse(int x)
        {
            long num = 0;
            while (x != 0)
            {
                int tail = x % 10;
                num = num * 10 + tail;
                x = x / 10;
            }

            //考虑溢出情况
            if (num > int.MaxValue || num < int.MinValue)
            {
                return 0;
            }
            return (int)num;
        }
    }
}
