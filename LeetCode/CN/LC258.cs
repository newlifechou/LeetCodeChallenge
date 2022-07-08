using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 各位相加
    /// 不使用循环或者递归，在 O(1) 时间复杂度内解决这个问题
    /// </summary>
    public class LC258
    {
        /// <summary>
        /// 循环方法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int AddDigits1(int num)
        {
            while (num >= 10)
            {
                int n = 0;
                while (num > 0)
                {
                    n += num % 10;
                    num /= 10;
                }
                num = n;
            }
            return num;
        }

        /// <summary>
        /// 数学方法,推导公式
        /// x+9与x的数根相同，即一个数加9后它的数根不变。
        /// a的数根b = (a-1) % 9+1, 即 mod(a-1, 9)+1，且a ∈ N*
        /// 
        /// 
        /// 除了传统的单纯循环，还可以找规律。假如一个三位数'abc'，
        /// 其值大小为s1 = 100 * a + 10 * b + 1 * c，经过一次各位相加后，
        /// 变为s2 = a + b + c，减小的差值为(s1 -s2) = 99 * a + 9 * b，
        /// 差值可以被9整除，每一个循环都这样，缩小了9的倍数。
        /// 当num小于9，即只有一位时，直接返回num，大于9时，
        /// 如果能被9整除，则返回9（因为不可能返回0也不可能返回两位数及以上的值），
        /// 如果不能被整除，就返回被9除的余数。
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int AddDigits2(int num)
        {
            return (num - 1) % 9 + 1;
        }



    }
}
