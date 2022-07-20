using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC322
    {
        public int CoinChange(int[] coins, int amount)
        {
            //建立不同面值最优解数组
            int[] dp = new int[amount + 1];
            for (int i = 0; i < amount + 1; i++)
            {
                dp[i] = -1;
            }
            //第一个
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    //当前面值小于i 且 剩余差值最优解已存在
                    if (coins[j] <= i && dp[i - coins[j]] != -1)
                    {
                        //当前面值最优解不存在 或者 当面面值最优解 比 剩余面值的最优解 大
                        //更新当面面值最优解为剩余面值最优解+1
                        if (dp[i] == -1 || dp[i] > dp[i - coins[j]])
                        {
                            dp[i] = dp[i - coins[j]] + 1;
                        }
                    }
                }
            }

            return dp[amount];
        }
    }
}
