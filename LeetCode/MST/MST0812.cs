using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MST
{
    /// <summary>
    /// 八皇后问题
    /// 
    /// </summary>
    public class MST0812
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns>[[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]</returns>
        public IList<IList<string>> SolveNQueens(int n)
        {
            //0可以放，1不可以放
            int[,] attack = new int[n, n];
            char[,] queen = new char[n, n];


            return null;
        }
    }
}
