using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 每日温度
    /// </summary>
    public class LC739
    {
        /// <summary>
        /// 可以维护一个存储下标的单调栈，从栈底到栈顶的下标对应的温度列表中的温度依次递减。
        /// 如果一个下标在单调栈里，则表示尚未找到下一次温度更高的下标。
        /// </summary>
        /// <param name="temperatures"></param>
        /// <returns></returns>
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int[] ret = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count != 0 &&
                    temperatures[i] > temperatures[stack.Peek()])
                {
                    int idx = stack.Pop();
                    ret[idx] = i - idx;
                }
                stack.Push(i);
            }
            return ret;
        }

    }
}
