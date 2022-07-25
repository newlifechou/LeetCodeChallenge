using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC037
    {
        public void SolveSudoku(char[][] board)
        {
            //init
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        //存储spaces的位置
                        spaces.Add(new int[] { i, j });
                    }
                    else
                    {
                        int digit = board[i][j] - '0' - 1;
                        line[i, digit] = colomn[j, digit] = block[i / 3, j / 3, digit] = true;
                    }
                }
            }


            dfs(board, 0);
        }

        //表示第i行，第j列，第x,y个九宫格填写每个数字的情况
        //line[1,8]=第1行，数字8是否满足要求
        private bool[,] line = new bool[9, 9];
        private bool[,] colomn = new bool[9, 9];
        private bool[,,] block = new bool[3, 3, 9];

        //dfs有效标志
        private bool valid = false;
        //存储空白字符，等待递归回溯
        private List<int[]> spaces = new List<int[]>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="pos"></param>
        private void dfs(char[][] board, int pos)
        {
            //
            if (pos == spaces.Count)
            {
                valid = true;
                return;
            }

            int[] space = spaces[pos];
            //获取当前space的i,j
            int i = space[0], j = space[1];

            for (int digit = 0; digit < 9 && !valid; digit++)
            {
                if (!line[i, digit] && !colomn[j, digit] && !block[i / 3, j / 3, digit])
                {
                    line[i, digit] = colomn[j, digit] = block[i / 3, j / 3, digit] = true;
                    board[i][j] = (char)(digit + '0' + 1);
                    
                    dfs(board, pos + 1);
                    //恢复
                    line[i, digit] = colomn[j, digit] = block[i/3, j/3, digit] = false;
                }
            }


        }



    }
}
