using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC567
    {
        /// <summary>
        /// 滑动窗口
        /// 统计出现的次数，比较是否相等
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool CheckInclusion1(string s1, string s2)
        {
            //s1短匹配，s2长
            int n1 = s1.Length, n2 = s2.Length;
            if (n1 > n2)
                return false;

            //统计s1中
            int[] cnt1 = new int[26];
            //统计当前遍历的子串的各个字符数目
            int[] cnt2 = new int[26];

            //对比一开始的n1个字符
            for (int i = 0; i < n1; i++)
            {
                cnt1[s1[i] - 'a']++;
                cnt2[s2[i] - 'a']++;
            }

            if (cnt1.SequenceEqual(cnt2))
            {
                return true;
            }

            //继续滑动对比剩余的
            for (int i = n1; i < n2; i++)
            {
                //多统计一次进入窗口的字符，少统计一次离开窗口的字符
                cnt2[s2[i] - 'a']++;
                cnt2[s2[i - n1] - 'a']--;
                if (cnt1.SequenceEqual(cnt2))
                {
                    return true;
                }
            }

            return false;
        }




        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool CheckInclusion2(string s1, string s2)
        {
            int n1 = s1.Length, n2 = s2.Length;
            if (n1 > n2)
            {
                return false;
            }

            int[] cnt = new int[26];
            for (int i = 0; i < n1; i++)
            {
                cnt[s1[i] - 'a']--;
            }

            int left = 0;
            for (int right = 0; right < n2; right++)
            {
                int x = s2[right] - 'a';
                cnt[x]++;

                while (cnt[x]>0)
                {
                    cnt[s2[left] - 'a']--;
                    left++;
                }

                if (right - left + 1 == n1)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
