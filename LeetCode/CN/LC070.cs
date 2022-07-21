using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC070
    {
        /// <summary>
        /// 动态规划
        /// f(x)=f(x-1)+f(x-2)
        /// f(0)=1
        /// f(1)=1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs1(int n)
        {
            int p = 0, q = 0, r = 1;
            for (int i = 1; i <= n; i++)
            {
                p = q;
                q = r;
                r = p + q;
            }
            return r;
        }

        public int ClimbStairs2(int n)
        {

        }


        public int ClimbStairs3(int n)
        {

        }
    }
}
