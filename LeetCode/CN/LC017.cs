using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC017
    {
        /// <summary>
        /// 回溯
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> LetterCombinations(string digits)
        {
            List<string> list = new List<string>();
            if (digits.Length == 0)
                return list;
            Dictionary<char, string> map = new Dictionary<char, string>();
            map.Add('2', "abc");
            map.Add('3', "def");
            map.Add('4', "ghi");
            map.Add('5', "jkl");
            map.Add('6', "mno");
            map.Add('7', "pqrs");
            map.Add('8', "tuv");
            map.Add('9', "wxyz");

            var sb = new StringBuilder();
            BackTrack(list, map, digits, 0, sb);

            return list;
        }

        private void BackTrack(List<string> c, Dictionary<char, string> d, string digits,
                                int index, StringBuilder sb)
        {
            if (index == digits.Length)
            {
                c.Add(sb.ToString());
            }
            else
            {
                char digit = digits[index];
                string letters = d[digit];
                for (int i = 0; i < letters.Length; i++)
                {
                    sb.Append(letters[i]);
                    BackTrack(c, d, digits, index + 1, sb);
                    sb.Remove(index, 1);
                }
            }
        }





    }
}
