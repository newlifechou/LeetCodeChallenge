using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC461
    {
        public int HammingDistance(int x, int y)
        {
            int s = x ^ y;
            int ret = 0;
            while (s != 0)
            {
                //取s&1最后一位
                //ret += s & 1;
                s = s & (s - 1);
                //右移
                //s = s >> 1;
                ret++;
            }
            return ret;
        }
    }
}
