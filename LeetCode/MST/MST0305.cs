using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MST
{
    internal class MST0305
    {
    }
    /// <summary>
    /// 使用递归
    /// </summary>
    public class SortedStack
    {

        private Stack<int> st;
        public SortedStack()
        {
            st = new Stack<int>();
        }


        private void MySort(int val)
        {
            if (IsEmpty() || val<=st.Peek())
            {
                st.Push(val);
            }
            else
            {
                int tmp = st.Pop();
                MySort(val);
                st.Push(tmp);
            }
        }

        public void Push(int val)
        {
            MySort(val);
        }


        public void Pop()
        {
            if (!IsEmpty())
            {
                st.Pop();
            }
        }

        public int Peek()
        {
            if(st.Count == 0)
            {
                return -1;
            }
            else
            {
                return st.Peek();
            }
        }

        public bool IsEmpty()
        {
            return st.Count == 0;
        }
    }
}
