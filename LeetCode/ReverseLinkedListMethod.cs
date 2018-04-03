using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-206
    /// </summary>
    public class ReverseLinkedListMethod
    {
        /// <summary>
        /// 利用三个指针改变链表方向，prev,current,next
        /// 要注意算法顺序
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList1(ListNode head)
        {
            ListNode prevPointer, currentPointer, nextPointer;

            prevPointer = null;
            currentPointer = head;
            while (currentPointer!=null)
            {
                nextPointer = currentPointer.next;
                currentPointer.next = prevPointer;
                prevPointer = currentPointer;
                currentPointer = nextPointer;
            }
            head = prevPointer;
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
