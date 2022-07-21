using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC008
    {
        public int MyAtoi(string s)
        {
            int len = s.Length;

            int index = 0;
            //去除前导空格
            while (index < len && s[index] == ' ')
            {
                index++;
            }

            //极端例子
            if (index == len)
                return 0;

            //记录第一个字符
            int sign = 1;
            char firstChar = s[index];
            if (firstChar == '+')
            {
                index++;
            }
            else if (firstChar == '-')
            {
                index++;
                sign = -1;
            }

            int res = 0;

            //获取少一位尾数的最大最小值
            int max_1 = int.MaxValue / 10;
            int min_1 = int.MinValue / 10;

            while (index < len)
            {
                char currentChar = s[index];
                if (currentChar > '9' || currentChar < '0')
                    break;

                int tmp = currentChar - '0';
                if (res > max_1 || (res == max_1 && tmp > 7))
                {
                    return int.MaxValue;
                }

                if (res < min_1 || (res == min_1 && tmp > 8))
                {
                    return int.MinValue;
                }
                res = res * 10 + sign * tmp;
                index++;
            }

            return res;

        }
    }
}
