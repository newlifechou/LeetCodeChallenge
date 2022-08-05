using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC191
    {
        public int HammingWeight(uint n)
        {
            int ret = 0;
            for (int i = 0; i < 32; i++)
            {
                //左移产生对应位上1，其他0，与运算后，1对应位置如果是1，则不为0，否则为0
                if ((n & (1 << i)) != 0)
                {
                    ret++;
                }
            }
            return ret;
        }
    }
}
