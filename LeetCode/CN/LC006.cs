using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC006
    {
        /// <summary>
        /// https://leetcode.cn/problems/zigzag-conversion/solution/6-z-zi-xing-bian-huan-c-c-by-bian-bian-xiong/
        /// 当curRow=0或者n-1的时候，箭头反转
        /// 从左到右迭代s，将每个字符添加到合适行，然后从上到下遍历即可
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string Convert(string s, int numRows)
        {
            //特殊情况
            if (numRows == 1)
                return s;

            //减少可能申请的数组
            int rowCount = Math.Min(s.Length, numRows);

            string[] rows = new string[rowCount];

            int curRow = 0;
            bool canTurn = false;

            foreach (var c in s)
            {
                rows[curRow] += c;
                if (curRow == 0 || curRow == numRows - 1)
                {
                    canTurn = !canTurn;
                }
                curRow += canTurn ? 1 : -1;
            }

            string ret = "";
            foreach (var item in rows)
            {
                ret += item;
            }
            return ret;
        }
    }
}
