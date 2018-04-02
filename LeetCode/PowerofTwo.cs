using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Leetcode-231
    /// </summary>
    public class PowerofTwo
    {
        /// <summary>
        /// 能否被2整除
        /// 如果是2的n次方，最后n==1；
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPowerOfTwo1(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            while (n % 2 == 0)
            {
                n = n / 2;
            }

            return n == 1;
        }

        /// <summary>
        /// 更好的办法
        /// 所有2的次方的二进制都是1后面n个0
        /// n和n-1如果做逻辑与运算，最后结果是0
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        public bool IsPowerOfTwo2(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            else if (n == 1)
            {
                return true;
            }
            else
            {
                return (n & (n - 1)) == 0;
            }


        }



    }
}
