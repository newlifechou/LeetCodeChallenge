using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC344
    {
        /// <summary>
        /// 反转字符串
        /// 原地修改，Ο(1)
        /// 前后两个位置的字符不断交换位置
        /// 
        /// 递归关系 reverse(s[0,n])  reverse(s[1,n-1])
        /// </summary>
        /// <param name="s"></param>
        public void ReverseString(char[] s)
        {
            Dfs(s, 0, s.Length - 1);
        }

        private void Dfs(char[] s,int start,int end)
        {
            if (start > end)
                return;
            Dfs(s,start+1,end-1);

            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;
        }


    }
}
