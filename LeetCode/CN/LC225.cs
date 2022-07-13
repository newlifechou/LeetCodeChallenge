using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC225
    {
        
        public LC225()
        {
            s1 = new Queue<int>();
            s2 = new Queue<int>();
        }

        private Queue<int> s1;
        private Queue<int> s2;
        public void Push(int x)
        {
            s1.Enqueue(x);
            //把s2的所有元素排在s1后面
            while (s2.Count!=0)
            {
                s1.Enqueue(s2.Dequeue());
            }
            //交换s1和s2
            Queue<int> temp = s2;
            s2 = s1;
            s1 = temp;
        }

        public int Pop()
        {
            return s2.Dequeue();
        }

        public int Top()
        {
            return s2.Peek();
        }

        public bool Empty()
        {
            return s2.Count == 0;
        }
    }
}
