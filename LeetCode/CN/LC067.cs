using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 二进制求和
    /// </summary>
    public class LC067
    {
        /// <summary>
        /// 模拟加法和进位
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary1(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int n = Math.Max(a.Length, b.Length);
            int carry = 0;
            for (int i = 0; i < n; i++)
            {
                int x = i < a.Length ? a[a.Length - 1 - i] - '0' : 0;
                int y = i < b.Length ? b[b.Length - 1 - i] - '0' : 0;
                carry = carry + x + y;
                sb.Append((char)(carry % 2 + '0'));
                carry /= 2;
            }

            if (carry > 0)
            {
                sb.Append('1');
            }


            return new string(sb.ToString().Reverse().ToArray());
        }

        /// <summary>
        /// 转化为10进制，计算后再转换到二进制
        /// 超大数字会有溢出问题
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary2(string a, string b)
        {
            Int64 x = Convert.ToInt64(a, 2);
            Int64 y = Convert.ToInt64(b, 2);
            Int64 z = x + y;

            string result = Convert.ToString(z, 2);
            return result;
        }

        /// <summary>
        /// 位运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary3(string a, string b)
        {

            return "";
        }
    }
}
