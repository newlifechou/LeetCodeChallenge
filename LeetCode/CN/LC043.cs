using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 字符串相乘
    /// </summary>
    public class LC043
    {
        /// <summary>
        /// 乘法，每位分别乘，之后加和
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int m = num1.Length;
            int n = num2.Length;

            int[] ansArr = new int[m + n];

            for (int i = m - 1; i >= 0; i--)
            {
                int x = num1[i] - '0';
                for (int j = n - 1; j >= 0; j--)
                {
                    int y = num2[j] - '0';
                    ansArr[i + j + 1] += x * y;
                }
            }

            for (int i = m + n - 1; i > 0; i--)
            {
                ansArr[i - 1] += ansArr[i] / 10;
                ansArr[i] %= 10;
            }

            int index = ansArr[0] == 0 ? 1 : 0;
            StringBuilder ans = new StringBuilder();
            while (index<m+n)
            {
                ans.Append(ansArr[index]);
                index++;
            }
            return ans.ToString();
        }
    }
}
