using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC066
    {
        /// <summary>
        /// 考虑进位
        /// 没有进位
        /// 进位到现有数字停止
        /// 进位到最高，需要增加一位
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;
                digits[i] %= 10;
                //说明没有进位
                if (digits[i] != 0)
                {
                    return digits;
                }
            }

            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;

        }
    }
}
