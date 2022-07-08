using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC946
    {
        /// <summary>
        /// 利用站FILO的属性是否矛盾
        /// 
        /// 按顺序入栈，检查栈顶是否和Popped序列头部相同，
        /// 相同Pop，不同继续Push
        /// </summary>
        /// <param name="pushed"></param>
        /// <param name="popped"></param>
        /// <returns></returns>
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();
            int popIndex = 0;
            foreach (var item in pushed)
            {
                stack.Push(item);
                while (stack.Count != 0 && stack.Peek() == popped[popIndex])
                {
                    stack.Pop();
                    popIndex++;
                }
            }


            return popIndex == pushed.Length;

        }

    }
}
