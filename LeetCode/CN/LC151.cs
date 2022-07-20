using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC151
    {
    }

    public class MinStack
    {
        //数据栈
        private Stack<int> data = new Stack<int>();
        //最小栈,栈顶就是最小值
        private Stack<int> mins = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int val)
        {
            data.Push(val);
            if (mins.Count != 0 && val > mins.Peek())
            {
                val = mins.Peek();
            }
            mins.Push(val);
        }

        public void Pop()
        {
            data.Pop();
            mins.Pop();
        }

        public int Top()
        {
            return data.Peek();
        }

        public int GetMin()
        {
            return mins.Peek();
        }
    }
}
