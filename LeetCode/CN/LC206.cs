using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC206
    {
        public class Solution
        {
            /// <summary>
            /// 原地移动法
            /// </summary>
            /// <param name="head"></param>
            /// <returns></returns>
            public ListNode ReverseList1(ListNode head)
            {
                ListNode current = null;
                ListNode previous = null;
                ListNode next = null;

                if (head == null || head.next == null)
                    return head;

                current = head;
                while (current!=null)
                {
                    next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                }

                return previous;
            }

            /// <summary>
            /// 遍历原来的链表，创建一个新的
            /// 会用掉很多空间
            /// </summary>
            /// <param name="head"></param>
            /// <returns></returns>
            public ListNode ReverseList2(ListNode head)
            {
                if (head == null || head.next == null)
                    return head;

                ListNode dummyHead = new ListNode(0);

                while (head!=null)
                {
                    ListNode node = new ListNode(head.val);
                    node.next = dummyHead.next;
                    dummyHead.next = node;
                    head = head.next;

                }

                return dummyHead.next;
            }

            /// <summary>
            /// 递归方法
            /// </summary>
            /// <param name="head"></param>
            /// <returns></returns>
            public ListNode ReverseList3(ListNode head)
            {
                if (head == null || head.next == null)
                    return head;

                ListNode sec = head.next;
                ListNode newHead = ReverseList3(head.next);
                sec.next = head;
                head.next = null;
                return newHead;

            }

        }

    }
}
