using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC009
    {
        /// <summary>
        /// 转换为字符串后处理
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome1(int x)
        {
            string s = x.ToString();
            StringBuilder sb = new StringBuilder();
            foreach (var c in s.Reverse())
            {
                sb.Append(c);
            }
            return s == sb.ToString();
        }

        /// <summary>
        /// 通过取整和取余获取对应位置数字
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome2(int x)
        {
            if (x < 0)
                return false;
            int div = 1;
            
            //一直循环到取到首位数字时候的div
            while ((x / div) >= 10)
                div *= 10;

            while (x>0)
            {
                //最左边
                int left = x / div;
                //取个位
                int right = x % 10;
                if (left != right)
                    return false;
                //x去掉首位
                x = (x % div) / 10;
                //除数缩小100倍
                div /= 100;
            }
            return true;

        }

        /// <summary>
        /// 取出后半部分数字翻转
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome3(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x>revertedNumber)
            {
                //取尾数并添加到revertedNumber后面
                revertedNumber = revertedNumber * 10 +x % 10;
                //原数去掉尾数
                x /= 10;
            }

            //奇偶情况区分
            return x == revertedNumber || 
                x == revertedNumber / 10;

        }


    }
}
