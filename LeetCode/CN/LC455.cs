using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 贪心算法-分配糖果
    /// </summary>
    public class LC455
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Sort(ref g);
            Sort(ref s);

            int child = 0;//已满足的孩子数
            int candy = 0;//已使用的糖果数
            while (candy < s.Length && child < g.Length)
            {
                if (s[candy] >= g[child])
                {
                    child++;
                }
                candy++;
            }

            return child;
        }

        private void Sort(ref int[] nums)
        {
            var list = nums.ToList();
            list.Sort();
            nums = list.ToArray();
        }
    }
}
