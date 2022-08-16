using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC345
    {
        public string ReverseVowels(string s)
        {
            int n = s.Length;
            char[] arr = s.ToCharArray();
            int i = 0, j = n - 1;
            while (i < j)
            {
                while (i < n && "aeiouAEIOU".IndexOf(arr[i]) < 0)
                {
                    i++;
                }
                while (j > 0 && "aeiouAEIOU".IndexOf(arr[j]) < 0)
                {
                    j--;
                }
                if (i < j)
                {
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            return new string(arr);
        }


    }
}
