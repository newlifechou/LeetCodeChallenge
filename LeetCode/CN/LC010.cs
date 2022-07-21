using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC010
    {
        /// <summary>
        /// 动态规划
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            int n_s = s.Length;
            int n_p = p.Length;
            //true表示s的前i个字符，p的前j个字符可以匹配
            bool[,] dp = new bool[n_s + 1, n_p + 1];
            //默认为false
            //s,p都为空
            dp[0, 0] = true;

            //s为空，p不空，*允许0个字符，只有a*a*a*a*a*可以匹配空串，其他都是false
            //奇数位不管什么字符都是false，偶数位*时
            for (int j = 1; j <= n_p; j ++)
            {
                //如果p的第j个字符是*，那么第j和第j-1个都可有可无，可以去掉
                //如果前j-2匹配上，那么前j个也可以
                if (p[j - 1] == '*')
                    dp[0, j] = dp[0, j - 2];
            }

            for (int i = 1; i <= n_s; i++)
            {
                for (int j = 1; j <= n_p; j++)
                {
                    //s和p的子串末尾字符能够匹配到
                    //s的第i个字符是s[i-1]，p的第j个字符是p[j-1]
                    if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                    {
                        //如果前i,前j匹配，那么前i-1,前j-1一定也匹配
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        //p的末尾p[j-1],即*前的一个字符p[j-2]能够和s串末尾匹配上
                        if (s[i - 1] == p[j - 2] || p[j - 2] == '.')
                        {
                            //0或者1以上
                            //如果前i,前j匹配，那么如果s的*位匹配0次，前i,前j-2肯定匹配
                            //如果前i,前j匹配, 如果s的*匹配多次，那么前i-1，前j肯定匹配
                            dp[i, j] = dp[i, j - 2] || dp[i - 1, j];
                        }
                        else
                        {
                            //0次匹配,前i，前j不匹配，那么前i，前j-1一定匹配，进而前i，前j-2匹配
                            dp[i, j] = dp[i, j - 2];
                        }

                    }

                }
            }


            return dp[n_s, n_p];

        }
    }
}
