using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC122
    {
        /// <summary>
        /// 所有上涨交易日都买卖，所有下跌交易日都不买卖
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int tmp = prices[i] - prices[i - 1];
                if (tmp > 0)
                    profit += tmp;
            }
            return profit;
        }
    }
}
