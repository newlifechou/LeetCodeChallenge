using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.JZ
{
    internal class JZ030
    {
    }

    public class MinStack
    {
        private Stack<int> stackData;
        private Stack<int> stackMin;

        /** initialize your data structure here. */
        public MinStack()
        {
            stackData = new Stack<int>();
            stackMin = new Stack<int>();
        }

        public void Push(int x)
        {
            stackData.Push(x);

            int newMin = x;
            if (stackMin.Count != 0 && x >= stackMin.Peek())
            {
                newMin = stackMin.Peek();
            }
            stackMin.Push(newMin);
        }

        public void Pop()
        {
            if(stackData.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            stackData.Pop();
            stackMin.Pop();
        }

        public int Top()
        {
            if (stackData.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return stackData.Peek();
        }

        public int Min()
        {
            if (stackMin.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return stackMin.Peek();
        }
    }
}
