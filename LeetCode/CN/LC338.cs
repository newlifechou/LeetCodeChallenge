using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC338
    {
        /// <summary>
        /// 分别计数，利用x&(x-1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] CountBits(int n)
        {
            int[] bits=new int[n+1];
            for (int i = 0; i <=n; i++)
            {
                bits[i] = CountOnes(i);
            }
            return bits;
        }
        private int CountOnes(int x)
        {
            int ones = 0;
            while (x>0)
            {
                x = x & (x - 1);
                ones++;
            }
            return ones;
        }


        /// <summary>
        /// dp
        /// dp[i]=dp[j]+1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] CountBits2(int n)
        {
            int[] bits = new int[n + 1];
            int highBit = 0;

            for (int i = 0; i <= n; i++)
            {
                if ((i & (i - 1)) == 0)
                {
                    highBit = i;
                }
                bits[i] = bits[i - highBit] + 1;
            }

            return bits;
        }


    }
}
