using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC096
    {
        /// <summary>
        /// 公式
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumTrees(int n)
        {
            int c = 1;
            for (int i = 0; i < n; i++)
            {
                c = c * 2 * (2 * i + 1) / (i + 2);
            }
            return (int)c;
        }
    }
}
