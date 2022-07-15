using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 有效的括号
    /// </summary>
    public class LC020
    {
        /// <summary>
        /// 栈方法FILO
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            if (s.Length == 0)
                return true;

            Stack<char> stack = new Stack<char>();
            //遍历一次
            foreach (var item in s.ToCharArray())
            {
                //如果是左边括号
                if ((item == '(') || (item == '[') || (item == '{'))
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char temp=stack.Pop();
                        if (item == ')')
                        {
                            if (temp != '(')
                            {
                                return false;
                            }
                        }
                        else if (item == ']')
                        {
                            if (temp != '[')
                            {
                                return false;
                            }
                        }
                        else if (item == '}')
                        {
                            if (temp != '{')
                            {
                                return false;
                            }
                        }
                    }
                }
            }


            return stack.Count == 0;
        }
    }
}
