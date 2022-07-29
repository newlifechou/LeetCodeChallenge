using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC593
    {
        /// <summary>
        /// 正方形判定定理
        /// 平行四边形
        /// 菱形
        /// 矩形
        /// 四条边都相等的是菱形
        /// 对角线都相等的是正方形
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <returns></returns>
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[][] points = new int[][] { p1, p2, p3, p4 };
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    //返回平方数
                    int d = Distance(points[i], points[j]);
                    if (dict.ContainsKey(d))
                    {
                        dict[d]++;
                    }
                    else
                    {
                        dict[d] = 1;
                    }
                }
            }

            if (dict.Count != 2)
            {
                return false;
            }

            int a = dict.Keys.ToArray()[0];
            int c = dict.Keys.ToArray()[1];

            if (a > c)
            {
                int tmp = c;
                c = a;
                a = tmp;
            }

            //满足勾股定理，满足各自数量
            return c == 2 * a && dict[a] == 4 && dict[c] == 2;
        }

        private int Distance(int[] p1, int[] p2)
        {
            return (p1[0] - p2[0]) * (p1[0] - p2[0]) + (p2[1] - p1[1]) * (p2[1] - p1[1]);
        }

    }
}
