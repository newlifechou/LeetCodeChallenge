using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC014
    {
        /// <summary>
        /// 当字符串数组长度为 0 时则公共前缀为空，直接返回
        ///令最长公共前缀 ans 的值为第一个字符串，进行初始化
        ///遍历后面的字符串，依次将其与 ans 进行比较，两两找出公共前缀，最终结果即为最长公共前缀
        ///如果查找过程中出现了 ans 为空的情况，则公共前缀不存在直接返回
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            string ans = strs[0];

            for (int i = 0; i < strs.Length; i++)
            {
                int j = 0;
                for (; j < strs[i].Length && j < ans.Length; j++)
                {
                    if (ans[j] != strs[i][j])
                    {
                        break;
                    }
                }
                ans = ans.Substring(0, j);
                if (ans == "")
                    return ans;
            }
            return ans;
        }
    }
}
