using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC415
    {
        /// <summary>
        /// 相同数位对齐，从低位到高位，考虑进1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string AddStrings(string num1, string num2)
        {
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int add = 0;

            StringBuilder sb = new StringBuilder();

            while (i >= 0 || j >= 0 || add != 0)
            {
                //利用ascii码相减得到对应数字
                int x = i >= 0 ? num1[i] - '0' : 0;
                int y = j >= 0 ? num2[j] - '0' : 0;
                int result = x + y + add;
                sb.Append(result % 10);
                add = result / 10;
                i--;
                j--;
            }
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
