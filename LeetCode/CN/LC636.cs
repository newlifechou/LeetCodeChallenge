using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC636
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            int[] ans = new int[n];
            Stack<int> d = new Stack<int>();
            int cur = -1;
            foreach (var log in logs)
            {
                string[] ss = log.Split(':');
                int idx = int.Parse(ss[0]);
                int ts = int.Parse(ss[2]);
                if (ss[1] == "start")
                {
                    if(d.Count != 0)
                    {
                        ans[d.Peek()] += (ts - cur);
                    }
                    d.Push(idx);
                    cur = ts;
                }
                else
                {
                    int func = d.Pop();
                    ans[func] += ts - cur + 1;
                    cur = ts + 1;
                }
            }
            return ans;
        }
    }
}
