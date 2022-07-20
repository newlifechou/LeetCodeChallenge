using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 盛最多的水
    /// </summary>
    internal class LC011
    {
        /// <summary>
        /// S(i,j)=min(h[i],h[j])*(j-i);
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            int i = 0, j = height.Length - 1, res = 0;
            while (i<j)
            {
                if(height[i] < height[j])
                {
                    res = Math.Max(res, (j - i) * height[i]);
                    i++;
                }
                else
                {
                    res = Math.Max(res, (j - i) * height[j]);
                    j--;
                }
            }
            return res;
        }
    }
}
