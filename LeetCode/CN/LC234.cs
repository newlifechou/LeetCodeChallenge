using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC234
    {
        public bool IsPalindrome1(ListNode head)
        {
            List<int> vals = new List<int>();
            ListNode cur = head;
            while (cur!=null)
            {
                vals.Add(cur.val);
                cur = cur.next;
            }

            int front = 0;
            int back=vals.Count-1;
            while (front<back)
            {
                if (vals[front] != vals[back])
                {
                    return false;
                }
                front++;
                back--;
            }
            return true;
        }
        public bool IsPalindrome2(ListNode head)
        {
            return false;
        }
    }
}
