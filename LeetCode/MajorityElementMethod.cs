using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Leetcode-169
    /// </summary>
    public class MajorityElementMethod
    {
        /*
         * 假设多数数字的个数大于n/2
         */


        /// <summary>
        /// 思路1
        /// 统计法-暴力方法
        /// 不好的办法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement1(int[] nums)
        {
            int majorityCount = nums.Length / 2;

            //循环统计
            foreach (var item1 in nums)
            {
                int count = 0;
                foreach (var item2 in nums)
                {
                    if (item1 == item2)
                    {
                        count++;
                    }
                }
                if (count > majorityCount)
                    return item1;
            }
            return -1;
        }

        /// <summary>
        /// 思路2
        /// 栈
        /// 入栈条件：栈空 或 栈顶元素=入栈元素
        /// 出栈条件：其他所有情况
        /// 一样的入栈（增加一个），不一样就出栈（相当于被其他数字消耗掉一个），如果都出完了就把地方让给别人
        /// 因为题目假设至少大于n/2,所以最多的元素再怎么消耗也会至少留下一个
        /// 最后栈底的元素就是最多的元素
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement2(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var item in nums)
            {
                //入栈条件
                if (stack.Count == 0 || stack.Peek() == item)
                {
                    stack.Push(item);
                }
                else
                {
                    stack.Pop();
                }
            }
            return stack.FirstOrDefault();

        }

        /// <summary>
        /// 继续优化思路2
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement3(int[] nums)
        {
            int candidate=0, count = 0;
            foreach (var item in nums)
            {
                //入栈条件
                if (count == 0 || candidate == item)
                {
                    candidate = item;
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return candidate;

        }


    }
}
