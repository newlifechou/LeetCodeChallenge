using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{

    public class LC160
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) { val = x; }
         * }
         */

        /// <summary>
        /// 暴力循环方法
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            ListNode headBFirst = headB;

            while (headA != null)
            {
                while (headB != null)
                {
                    if (headA == headB)
                    {
                        return headA;
                    }
                    headB = headB.next;
                }
                headA = headA.next;
                headB = headBFirst;
            }
            return null;
        }

        /// <summary>
        /// 通过地址Set的方法完成
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            while (headA != null)
            {
                visited.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (visited.Contains(headB))
                {
                    return headB;
                }
                headB = headB.next;
            }
            return null;

        }

        /// <summary>
        /// 双指针扫描
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode3(ListNode headA, ListNode headB)
        {
            int lengthA = GetLength(headA);
            int lengthB = GetLength(headB);

            int count = lengthA - lengthB;
            if (count > 0)
            {
                headA = MovePointer(headA, count);
            }
            else
            {
                headB = MovePointer(headB, -count);
            }

            ListNode result = null;
            while (headA != null && headB != null)
            {
                if (headA == headB)
                {
                    result = headA;
                    break;
                }
                headA = headA.next;
                headB = headB.next;
            }
            return result;
        }

        /// <summary>
        /// 遍历获得链表长度
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        private int GetLength(ListNode head)
        {
            int length = 0;

            ListNode cursor = head;
            while (cursor != null)
            {
                length++;
                cursor = cursor.next;
            }
            return length;
        }

        /// <summary>
        /// 移动头结点位置到count
        /// </summary>
        /// <param name="head"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private ListNode MovePointer(ListNode head, int count)
        {
            for (int i = 0; i < count; i++)
            {
                head = head.next;
            }
            return head;
        }



    }
}