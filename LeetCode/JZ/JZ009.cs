using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.JZ
{
    internal class JZ009
    {
    }

    public class CQueue
    {
        private Stack<int> stackIn;
        private Stack<int> stackOut;
        public CQueue()
        {
            stackIn = new Stack<int>();
            stackOut = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            stackIn.Push(value);
        }

        public int DeleteHead()
        {
            if (stackIn.Count == 0 && stackOut.Count == 0)
            {
                return -1;
            }

            if (stackOut.Count == 0)
            {
                //此时转移数据从in到out
                while (stackIn.Count > 0)
                {
                    stackOut.Push(stackIn.Pop());
                }
            }

            return stackOut.Pop();
        }
    }


}
