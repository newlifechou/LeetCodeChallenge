using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-190
    /// </summary>
    public class ReverseBitsSolution
    {
        /// <summary>
        /// 位运算
        /// 掩码
        /// 分组交换 移位 与运算实现
        /// </summary>
        /// <param name="n">输入是无符号32位bit</param>
        /// <returns>输出是无符号32bit</returns>
        public uint ReverseBits1(uint n)
        {
            //定义过滤器
            uint m_1 =  0x55555555;//0101 0101 0101 0101 0101 0101 0101 0101 
            uint m_2 =  0x33333333;//0011 0011 0011 0011 0011 0011 0011 0011
            uint m_4 =  0x0f0f0f0f;//0000 1111 0000 1111 0000 1111 0000 1111 
            uint m_8 =  0x00ff00ff;//0000 0000 1111 1111 0000 0000 1111 1111 
            uint m_16 = 0x0000ffff; //0000 0000 0000 0000 1111 1111 1111 1111

            uint a = ((n & m_16) << 16) + ((n >> 16) & m_16);
            uint b = ((a & m_8) << 8) + ((a >> 8) & m_8);
            uint c = ((b & m_4) << 4) + ((b >> 4) & m_4);
            uint d = ((c & m_2) << 2) + ((c >> 2) & m_2);
            uint e = ((d & m_1) << 1) + ((d >> 1) & m_1);

            return e;
        }

        /// <summary>
        /// 移位操作
        /// 思路很好
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public uint ReverseBits2(uint n)
        {
            uint result = 0;
            //循环32次，扫描每一位
            for (int i = 0; i < 32; i++)
            {
                //判断n的最后一位
                if ((n & 1) == 1)
                {
                    //结果往左移，将低位逐渐移动到高位
                    result = (result << 1) + 1;
                }
                else
                {
                    result = (result << 1);
                }
                //n往右移，将高位逐渐移动到低位
                n = n >> 1;
            }
            return result;
        }

    }
}
