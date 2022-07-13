using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC792
    {
        /// <summary>
        /// 匹配子序列的单词书
        /// 暴力匹配
        /// 二分法优化结果
        /// </summary>
        /// <param name="s"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public int NumMatchingSubseq(string s, string[] words)
        {
            int ans = 0;
            ca = s.ToArray();
            foreach (var word in words)
            {
                if (subseq(word))
                    ans++;
            }

            return ans;
        }

        private bool subseq(string word)
        {
            int i = 0;
            cb = word.ToArray();
            foreach (var c in ca)
            {
                if (i < cb.Length && c == cb[i])
                    i++;
            }
            return i == cb.Length;
        }
        private char[] ca, cb;


        public int NumMatchingSubseq1(string s, string[] words)
        {
            int ans = 0;
            //利用字典建立一个桶
            //字母为key，列表为value，列表值是一个自定义对象，可以记录word和对应的index
            Dictionary<char, List<WordString>> heads = new Dictionary<char, List<WordString>>();
            //初始化
            for (int i = 0; i < 26; i++)
            {
                heads[(char)(i + 'a')] = new List<WordString>();
            }

            //第一次按照单词首字母装桶
            foreach (var word in words)
            {
                heads[word[0]].Add(new WordString { Word = word, Index = 0 });
            }


            foreach (char c in s.ToCharArray())
            {
                List<WordString> old_bucket = heads[c];
                heads[c] = new List<WordString>();

                foreach (var item in old_bucket)
                {
                    item.Index++;
                    //说明这个词已经被匹配完了，说明存在
                    if (item.Index == item.Word.Length)
                    {
                        ans++;
                    }
                    else
                    {
                        heads[item.Word[item.Index]].Add(item);
                    }
                }

                old_bucket.Clear();
            }

            return ans;
        }



    }

    public class WordString
    {
        public string Word;
        public int Index;
    }



}
