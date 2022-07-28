using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MST
{
    internal class MST0302
    {

    }


    public class MinStack
    {

        //正常
        private Stack<int> stackData;
        //每一步的最小值
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
            if (stackMin.Count == 0)
            {
                stackMin.Push(x);
            }
            else
            {
                if (x<=stackMin.Peek())
                {
                    stackMin.Push(x);
                }
            }
        }

        public void Pop()
        {
            if(stackData.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            int x=stackData.Pop();
            if (x == stackMin.Peek())
            {
                stackMin.Pop();
            }
        }

        public int Top()
        {
            return stackData.Peek();
        }

        public int GetMin()
        {
            if (stackData.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return stackMin.Peek();
        }
    }



}
