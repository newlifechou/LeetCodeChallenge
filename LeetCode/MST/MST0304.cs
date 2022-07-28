using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MST
{
    internal class MST0304
    {
    }

    public class MyQueue
    {
        private Stack<int> stackPush;
        private Stack<int> stackPop;

        /** Initialize your data structure here. */
        public MyQueue()
        {
            stackPush = new Stack<int>();
            stackPop = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stackPush.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (stackPop.Count == 0 && stackPush.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (stackPop.Count == 0)
            {
                while (stackPush.Count != 0)
                {
                    stackPop.Push(stackPush.Pop());
                }
            }

            return stackPop.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (stackPop.Count == 0 && stackPush.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (stackPop.Count == 0)
            {
                while (stackPush.Count != 0)
                {
                    stackPop.Push(stackPush.Pop());
                }
            }

            return stackPop.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stackPop.Count == 0 && stackPush.Count == 0;
        }
    }
}
