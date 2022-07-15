using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 移除链表元素
    /// </summary>
    public class LC203
    {
        /// <summary>
        /// Recursion递归
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode RemoveElements1(ListNode head, int val)
        {
            //终止条件是head==null
            if (head == null)
                return head;
            head.next = RemoveElements1(head.next, val);
            return head.val == val ? head.next : head;
        }

        /// <summary>
        /// Iteration迭代
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode RemoveElements2(ListNode head, int val)
        {
            //定义一个新节点，它的next就是新链表的head
            ListNode dummyHead = new ListNode(0);

            dummyHead.next = head;
            ListNode tmp=dummyHead;
            while (tmp.next!=null)
            {
                if (tmp.next.val == val)
                {
                    //跳过这个要删除的node
                    tmp.next = tmp.next.next;
                }
                else
                {
                    tmp = tmp.next;
                }
            }
            return dummyHead.next;
        }
    }
}
