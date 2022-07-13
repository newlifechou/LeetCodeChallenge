using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 用栈实现队列
    /// </summary>
    public class LC232
    {
        private Stack<int> s1;
        private Stack<int> s2;
        public LC232()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        public void Push(int x)
        {
            s1.Push(x);
        }

        public int Pop()
        {
            if (s2.Count == 0)
            {
                while (s1.Count != 0)
                {
                    s2.Push(s1.Pop());
                }
            }
            return s2.Pop();

        }

        public int Peek()
        {
            if (s2.Count == 0)
            {
                while (s1.Count != 0)
                {
                    s2.Push(s1.Pop());
                }
            }
            return s2.Peek();
        }

        public bool Empty()
        {
            return s1.Count==0&&s2.Count==0;
        }
    }
}
