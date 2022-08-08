using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC278
    {
        /// <summary>
        /// 二分法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FirstBadVersion(int n)
        {
            int left=1,right=n;

            while (left<right)
            {
                int mid = left + (right - left) / 2;
                //if (IsBadVersion(mid))
                if(true)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
