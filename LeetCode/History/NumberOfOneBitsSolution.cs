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
    public class NumberOfOneBitsSolution
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

        /// <summary>
        /// 思路类似1
        /// 分组归并
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HamingWeight3(uint n)
        {
            //定义多组要用到的掩码
            uint m_1 = 0x55555555; //0101 0101 0101 0101 0101 0101 0101 0101
            uint m_2 = 0x33333333; //0010 0010 0010 0010 0010 0010 0010 0010 
            uint m_4 = 0x0f0f0f0f; //0000 1111 0000 1111 0000 1111 0000 1111
            uint m_8 = 0x00ff00ff; //0000 0000 1111 1111 0000 0000 1111 1111 
            uint m_16 = 0x0000ffff;//0000 0000 0000 0000 1111 1111 1111 1111 

            uint a = (n & m_1) + ((n >> 1) & m_1);
            uint b = (a & m_2) + ((a >> 2) & m_2);
            uint c = (b & m_4) + ((b >> 4) & m_4);
            uint d = (c & m_8) + ((c >> 8) & m_8);
            uint f = (d & m_16) + ((d >> 16) & m_16);

            return (int)f;
        }



    }
}
