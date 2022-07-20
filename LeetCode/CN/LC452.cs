using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 用少量箭射击气球
    /// </summary>
    public class LC452
    {
        /// <summary>
        /// 射击区间
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public int FindMinArrowShots(int[][] points)
        {
            //排除空数据
            if (points.Length == 0)
                return 0;
            //按照每个气球的left边界从小到大排序
            //Array.Sort(points, (p1, p2) => p1[0] - p2[0]);
            //处理极端数据溢出
            Array.Sort(points, (p1, p2) => p1[0].CompareTo(p2[0]));

            int arrow_count = 1;
            //射击区间右
            int interval_right = points[0][1];
            for (int i = 1; i < points.Length; i++)
            {
                //区间右大于等于第二个气球的左，则可以射击到
                if (interval_right >= points[i][0])
                {
                    //缩小区间
                    if (interval_right > points[i][1])
                    {
                        interval_right = points[i][1];
                    }
                }
                else
                {
                    //没有重叠区域，需要加一只箭
                    arrow_count++;
                    interval_right = points[i][1];
                }
            }

            return arrow_count;
        }
    }
}
