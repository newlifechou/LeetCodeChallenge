using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 最近的请求数
    /// </summary>
    internal class LC933
    {

    }

    /// <summary>
    /// 我们可以用一个队列维护发生请求的时间，当在时间 tt 收到请求时，将时间 tt 入队。
    ///由于每次收到的请求的时间都比之前的大，因此从队首到队尾的时间值是单调递增的。
    ///当在时间 tt 收到请求时，为了求出[t - 3000, t][t−3000, t] 内发生的请求数，
    ///我们可以不断从队首弹出早于 t-3000t−3000 的时间。
    ///循环结束后队列的长度就是[t - 3000, t][t−3000, t] 内发生的请求数。
    /// </summary>
    public class RecentCounter
    {
        private Queue<int> q;
        public RecentCounter()
        {
            q = new Queue<int>();
        }

        public int Ping(int t)
        {
            q.Enqueue(t);
            while (q.Peek() < t - 3000)
            {
                q.Dequeue();
            }
            return q.Count;
        }
    }

    /**
    * Your RecentCounter object will be instantiated and called as such:
    * RecentCounter obj = new RecentCounter();
    * int param_1 = obj.Ping(t);
    */
}
