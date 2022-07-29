using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.JZ
{
    internal class JZ031
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> tmpStack = new Stack<int>();
            int poppedIndex = 0;

            foreach (var item in pushed)
            {
                tmpStack.Push(item);
                while (tmpStack.Count != 0 && tmpStack.Peek() == popped[poppedIndex])
                {
                    tmpStack.Pop();
                    poppedIndex += 1;
                }
            }

            return tmpStack.Count == 0;
        }
    }
}
