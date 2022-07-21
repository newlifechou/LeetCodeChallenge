using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 最长回文串
    /// </summary>
    internal class LC005
    {
        private bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }
        /// <summary>
        /// 暴力法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome1(string s)
        {
            string ans = "";
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    string test = s.Substring(i, j);
                    if (IsPalindrome(test) && test.Length > max)
                    {
                        ans = test;
                        max = test.Length;
                    }
                }
            }
            return ans;
        }

        /// <summary>
        /// 翻转后，最长公共子串
        /// 动态规划
        /// S(i,j)=S(i+1,j-1)
        /// 二维数组表示
        /// arr[i][j]=arr[i-1][j-1]+1
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome2(string s)
        {
            int len = s.Length;
            if (len < 2)
                return s;

            //确定最终回文字符串
            int maxLen = 1;
            int begin = 0;

            //二维数组表示i到j的子串是否是回文串
            bool[,] dp = new bool[len, len];

            //所有长度为1的子串肯定都是回文串
            for (int i = 0; i < len; i++)
            {
                dp[i, i] = true;
            }

            //遍历子串长度
            for (int L = 2; L <= len; L++)
            {
                //左边界
                for (int i = 0; i < len; i++)
                {
                    int j = i + L - 1;

                    if (j >= len)
                        break;

                    if (s[i] != s[j])
                    {
                        dp[i, j] = false;
                    }
                    else
                    {
                        //最小子串长度为2的时候
                        if (j - i < 3)
                        {
                            dp[i, j] = true;
                        }
                        else
                        {
                            dp[i, j] = dp[i + 1, j - 1];
                        }
                    }

                    //子串回文成立，且出现最大子串
                    if (dp[i, j] && j - i + 1 > maxLen)
                    {
                        maxLen = j - i + 1;
                        begin = i;
                    }

                }
            }


            return s.Substring(begin,maxLen);
        }


    }
}
