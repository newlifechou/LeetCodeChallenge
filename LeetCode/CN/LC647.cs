using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC647
    {
        /// <summary>
        /// 动态规划
        /// 状态：dp[i][j]表示s在i,j区间是否是一个回文串
        /// 状态转移方程 s[i]=s[j]&&(j-i<2||dp[i+1][j-1]，then dp[i][j]=true
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountSubstrings(string s)
        {
            bool[,] dp = new bool[s.Length, s.Length];
            int ans = 0;
            for (int j = 0; j < s.Length; j++)
            {
                for (int i = 0; i <= j; i++)
                {
                    if (s[i] == s[j] && (j - i < 2 || dp[i + 1, j - 1]))
                    {
                        dp[i, j] = true;
                        ans++;
                    }
                }
            }

            return ans;

        }
    }
}
