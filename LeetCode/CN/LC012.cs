using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC012
    {
        /// <summary>
        /// 从左到右尽量找最大的
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string IntToRoman(int num)
        {
            Dictionary<int, string> values = new Dictionary<int, string>();
            values.Add(1000, "M");
            values.Add(900, "CM");
            values.Add(500, "D");
            values.Add(400, "CD");
            values.Add(100, "C");
            values.Add(90, "XC");
            values.Add(50, "L");
            values.Add(40, "XL");
            values.Add(10, "X");
            values.Add(9, "IX");
            values.Add(5, "V");
            values.Add(4, "IV");
            values.Add(1, "I");

            string ans = "";
            foreach (var item in values)
            {
                while (num >= item.Key)
                {
                    num -= item.Key;
                    ans += item.Value;
                }
                if (num == 0)
                    break;
            }

            return ans;
        }




    }
}
