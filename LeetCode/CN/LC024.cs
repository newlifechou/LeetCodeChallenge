using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC024
    {
        /// <summary>
        /// 两两交换链表中的节点
        /// 1234
        /// 2143
        /// 递归关系
        /// swappairs(head)   swappairs(head.next.next)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairs(ListNode head)
        {
            //递归退出条件
            if (head == null || head.next == null)
                return head;

            ListNode next =head.next;
            head.next = SwapPairs(next.next);
            next.next = head;
            return next;

        }
    }
}
