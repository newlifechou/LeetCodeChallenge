using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-191
    /// </summary>
    public class NumberOfOneBits
    {
        /// <summary>
        /// 汉明权重 一串符号中非0符号的个数
        /// 思路
        /// 逻辑与 操作 作为掩码
        /// 还有一种思路是在这个思路的基础上，采用分组归并的思路
        /// </summary>
        /// <param name="n">无符号10进制数</param>
        /// <returns></returns>
        public int HammingWeight1(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                //判定最后一位是否是1
                if ((n & 1) == 1)
                {
                    count++;
                }
                //右移操作符
                n = n >> 1;
            }
            return count;
        }
        /// <summary>
        /// 利用取余 不断除2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HammingWeight2(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                //相当于判断最后一位是否是1
                if (n % 2 == 1)
                {
                    count++;
                }
                //相当于二进制右移
                n = n / 2;
            }
            return count;
        }

    }
}
