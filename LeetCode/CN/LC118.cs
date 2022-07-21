using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> ans = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(ans[i - 1][j - 1] + ans[i - 1][j]);
                    }
                }

                ans.Add(row);
            }

            return ans;

        }
    }
}
