using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 括号的生成
    /// n对所有可能有效的括号组合
    /// 回溯法
    /// 无效情况
    /// l>=r无效
    /// l<r
    /// l=r=n
    /// </summary>
    public class LC022
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            if (n == 0)
                return result;
            Help(n, result, 0, 0, "");
            return result;
        }

        /// <summary>
        /// 回溯
        /// </summary>
        /// <param name="n"></param>
        /// <param name="result"></param>
        /// <param name="left">左括号已使用数</param>
        /// <param name="right">右括号已使用数</param>
        /// <param name="s">当前递归的结果</param>
        private void Help(int n, List<string> result, int left, int right, string s)
        {
            //递归停止条件
            //如果右括号已使用个数大于左，剪枝
            if (right > left)
                return;

            if (left == n && left == right)
            {
                result.Add(s);
                return;
            }

            if (left < n)
            {
                Help(n, result, left + 1, right, s + '(');
            }

            if (right < left)
            {
                Help(n, result, left, right + 1, s + ')');
            }
        }


    }
}
