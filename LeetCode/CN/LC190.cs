using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC190
    {
        public uint reverseBits(uint n)
        {
            uint rev = 0;
            for (int i = 0; i < 32 && n != 0; i++)
            {
                uint tailBit = n & 1;
                uint r = tailBit << (31 - i);
                rev = rev | r;
                n = n >> 1;
            }
            return rev;
        }
    }
}
