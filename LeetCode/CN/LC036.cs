using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC036
    {
        //用HashTable记录每行，每列，每个九宫格中每个数字出现的次数
        //用9x9二维数组分别记录每行每列出现的次数
        //用3x3x9三维数组记录每个九宫格出现的次数
        public bool IsValidSudoku(char[][] board)
        {
            int[,] rows = new int[9, 9];
            int[,] columns = new int[9, 9];
            int[,,] subboxes = new int[3, 3, 9];

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    char c = board[i][j];
                    if (c != '.')
                    {
                        int index = c - '0' - 1;

                        rows[i,index]++;
                        columns[j,index]++;
                        subboxes[i / 3, j / 3, index]++;
                        if (rows[i, index] > 1 || columns[j, index] > 1 || 
                            subboxes[i/3,j/3,index]>1)
                        {
                            return false;
                        }
                    }


                }
            }

            return true;
        }
    }
}
