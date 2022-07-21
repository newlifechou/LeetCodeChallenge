using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC119
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i <= rowIndex; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(list[i - 1][j - 1] + list[i - 1][j]);
                    }
                }
                list.Add(row);
            }

            return list[rowIndex];
        }


        /// <summary>
        /// 滚动
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetRow1(int rowIndex)
        {
            List<int> pre = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                List<int> cur = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        cur.Add(1);
                    }
                    else
                    {
                        cur.Add(pre[j - 1] + pre[j]);
                    }
                }
                pre = cur;
            }

            return pre;
        }




    }
}
