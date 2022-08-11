using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC640
    {
        public string SolveEquation(string equation)
        {
            //分别记录系数和数值
            int factor = 0;
            int val = 0;

            int index = 0;
            int n = equation.Length;
            int sign1 = 1;

            while (index < n)
            {
                //等号右边开始系数为负
                if (equation[index] == '=')
                {
                    sign1 = -1;
                    index++;
                    continue;
                }

                int sign2 = sign1, number = 0;
                bool valid = false;
                //确定符号正负
                if (equation[index] == '-' || equation[index] == '+')
                {
                    sign2 = (equation[index] == '-' ? -sign1 : sign1);
                    index++;
                }

                //连续读取数字
                while (index < n && char.IsDigit(equation[index]))
                {
                    number = number * 10 + (equation[index] - '0');
                    index++;
                    valid = true;
                }

                //判断是系数还是数值
                if (index < n && equation[index] == 'x')
                {
                    factor += valid ? sign2 * number : sign2;
                    index++;
                }
                else
                {
                    val += sign2 * number;
                }
            }

            //判断系数为0的情况
            if (factor == 0)
            {
                return val == 0 ? "Infinite solutions" : "No solution";
            }

            return "x=" + (-val / factor);
        }
    }
}
