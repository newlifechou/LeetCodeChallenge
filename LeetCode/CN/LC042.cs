using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC042
    {
        /// <summary>
        /// 接雨水问题
        /// 双游标
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap1(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;

            int l = 0, r = height.Length - 1;
            int maxLeft=0, maxRight=0;
            int totalWater = 0;
            while (l<r)
            {
                //判断左边低还是右边低
                if (height[l] < height[r])
                {
                    //找到左边最高的地方
                    if (height[l] >= maxLeft)
                    {
                        maxLeft = height[l];
                    }
                    else
                    {
                        totalWater += maxLeft - height[l];
                    }
                    l++;
                }
                else
                {
                    if (height[r] >= maxRight)
                    {
                        maxRight = height[r];
                    }
                    else
                    {
                        totalWater += maxRight - height[r];
                    }
                    r--;
                }
            }

            return totalWater;
        }


        /// <summary>
        /// 单调栈
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap2(int[] height)
        {
            return 0;
        }
    }
}
