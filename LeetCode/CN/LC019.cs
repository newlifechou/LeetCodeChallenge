using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC019
    {
        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummyHead = new ListNode(-1);
            dummyHead.next = head;

            ListNode p = dummyHead;
            ListNode q = dummyHead;

            //拉开n个距离后同时移动到q指向null，即q是最后一个节点的下一个节点
            //循环n+1次
            for (int i = 0; i < n+1; i++)
            {
                q = q.next;
            }

            while (q!=null)
            {
                p = p.next;
                q = q.next;
            }

            //删除p的下一个节点
            ListNode delNode = p.next;
            p.next = delNode.next;


            return dummyHead.next;

        }
    }
}
