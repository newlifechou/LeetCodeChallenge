﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC083
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode cur = head;
            while (cur!=null&&cur.next!=null)
            {
                if(cur.val==cur.next.val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }
            return head;
        }
    }
}
