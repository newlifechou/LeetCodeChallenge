using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-13
    /// </summary>
    public class RomanToIntegerSolution
    {
        /*
         * Ⅰ（1）,V（5）,X（10）,L（50）,C（100）,D（500）,M（1000）
         * I=1
         * II=2
         * III=3
         * IX=4
         * V=5
         * VI=6
         * VII=7
         * VIII=8
         * IX=9
         * X=10
         * XI=11
         * XII=12
         * XIII=13
         * IXV=14
         * XV=15
         * XXXVIII=38
         * XX=20
         * CC=200
         * 减法：小数字写在大数字左边
         * 加法：小数字写在大数字右边
         */

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            char[] romans = s.ToCharArray();
            int l = 0;
            int r = romans.Length - 1;
            int finalResult = RomanToNumber(romans, l, r);
            return finalResult;
        }

        /// <summary>
        /// 递归
        /// 最大值 - 它的左边 + 它的右边
        /// </summary>
        /// <param name="ch"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private int RomanToNumber(char[] ch, int l, int r)
        {
            //递归出口
            if (l == r)
            {
                return DigitsToValues(ch[l]);
            }
            else if (l > r)
            {
                return 0;
            }
            else
            {
                //找到最大的字母
                int m = FindMaxIndex(ch, l, r);
                int max = DigitsToValues(ch[m]);

                int left = RomanToNumber(ch, l, m - 1);
                int right = RomanToNumber(ch, m + 1, r);
                return max - left + right;
            }
        }

        /// <summary>
        /// 找出最大的罗马数字字符位置
        /// </summary>
        /// <param name="str"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private int FindMaxIndex(char[] str, int l, int r)
        {
            int max = DigitsToValues(str[l]);
            int maxIndex = l;
            for (int i = l; i <= r; i++)
            {
                int num = DigitsToValues(str[i]);
                if (num > max)
                {
                    max = num;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// 转换罗马字符到数字
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        private int DigitsToValues(char ch)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == ch)
                {
                    return values[i];
                }
            }
            return 0;
        }

        private char[] digits = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        private int[] values = { 1, 5, 10, 50, 100, 500, 1000 };
    }
}
