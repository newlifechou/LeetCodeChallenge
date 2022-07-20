using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 翻转链表指定部分
    /// </summary>
    public class LC092
    {
        /// <summary>
        /// 截断，翻转，再连接
        /// </summary>
        /// <param name="head"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public ListNode ReverseBetween1(ListNode head, int left, int right)
        {
            ListNode dummyNode = new ListNode(-1);
            dummyNode.next = head;

            ListNode pre = dummyNode;
            //从虚拟头结点走left-1步，到left的前一个节点
            for (int i = 0; i < left-1; i++)
            {
                pre = pre.next;
            }

            //从pre再走right-left+1,到right节点
            ListNode rightNode = pre;
            for (int i = 0; i < right-left+1; i++)
            {
                rightNode = rightNode.next;
            }

            ListNode leftNode = pre.next;
            ListNode succ = rightNode.next;

            //切断
            pre.next = null;
            rightNode.next = null;

            Help(leftNode);

            //重新连接
            pre.next = rightNode;
            leftNode.next = succ;

            return dummyNode.next;

        }
        /// <summary>
        /// LC206翻转链表
        /// </summary>
        /// <param name="head"></param>
        private void Help(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;

            while (cur!=null)
            {
                ListNode next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }
        }

        /// <summary>
        /// 对需要翻转的部分进行类似冒泡的操作
        /// </summary>
        /// <param name="head"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public ListNode ReverseBetween2(ListNode head, int left, int right)
        {
            ListNode dummyNode = new ListNode(-1);
            dummyNode.next = head;

            ListNode pre = dummyNode;
            //来到left前一个位置
            for (int i = 0; i < left-1; i++)
            {
                pre=pre.next;
            }

            //需要翻转的第一个节点
            ListNode cur = pre.next;
            ListNode next;
            //开始遍历需要翻转的部分
            for (int i = 0; i < right-left; i++)
            {
                next=cur.next;
                cur.next = next.next;
                next.next = pre.next;
                pre.next = next;
            }

            return dummyNode.next;

        }

    }
}
