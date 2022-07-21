using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC013
    {
        /// <summary>
        /// 小数在大数左边为减，
        /// 依次转换，控制加减
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            Dictionary<char,int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int value = map[s[i]];

                if (i < s.Length - 1 && value < map[s[i + 1]])
                {
                    ans -= value;
                }
                else
                {
                    ans += value;
                }
            }

            return ans;

        }
    }
}
