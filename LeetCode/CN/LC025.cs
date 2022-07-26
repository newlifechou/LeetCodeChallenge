using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC025
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            //pre每次翻转链表的头结点的上一个,end是尾结点
            ListNode prev = dummy;
            ListNode tail = dummy;

            while (tail.next != null)
            {
                //找到需要翻转的链表的结尾
                for (int i = 0; i < k && tail != null; i++)
                {
                    tail = tail.next;
                }

                if (tail == null)
                    break;

                //记录tail的next
                ListNode next = tail.next;

                tail.next = null;

                //记录要翻转链表的head,反转后的最后一个
                ListNode start = prev.next;

                prev.next = Reverse(start);

                start.next = next;

                prev = start;

                tail = start;
            }

            return dummy.next;
        }

        private ListNode Reverse(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode preNode = null;
            ListNode curNode = head;
            ListNode nextNode = null;

            while (curNode != null)
            {
                nextNode = curNode.next;
                curNode.next = preNode;
                preNode = curNode;
                curNode = nextNode;
            }
            return preNode;
        }


    }
}
