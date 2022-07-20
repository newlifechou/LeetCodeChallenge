using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 
    /// </summary>
    public class LC473
    {
        /// <summary>
        /// 长度是周长的四分之一
        /// 暴力时间会超时，需要排序，需要剪枝
        /// </summary>
        /// <param name="matchsticks"></param>
        /// <returns></returns>
        public bool Makesquare(int[] matchsticks)
        {
            if (matchsticks.Length == 0)
                return false;


            int perimeter = 0;
            for (int i = 0; i < matchsticks.Length; i++)
            {
                perimeter += matchsticks[i];
            }

            if (perimeter % 4 != 0)
                return false;

            int edge = perimeter / 4;

            //降序排列
            Array.Sort(matchsticks);
            Array.Reverse(matchsticks);

            int[] bucket = new int[4];
            return Backtrack(0,matchsticks,edge,bucket);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">正在放的下标</param>
        /// <param name="matchsticks">存储的长度</param>
        /// <param name="edge">边长</param>
        /// <param name="bucket">存储4条边的高度</param>
        /// <returns></returns>
        private bool Backtrack(int i, int[] matchsticks,int edge,int[] bucket)
        {
            if (i >= matchsticks.Length)
                return true;

            for (int j = 0; j < 4; j++)
            {
                if (bucket[j] + matchsticks[i] > edge)
                    continue;

                bucket[j] += matchsticks[i];
                if (Backtrack(i + 1, matchsticks, edge, bucket))
                    return true;
                //桶高度回溯
                bucket[j] -= matchsticks[i];
            }

            return false;

        }


    }
}
