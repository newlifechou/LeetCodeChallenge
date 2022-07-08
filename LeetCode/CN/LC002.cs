using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 两数相加
    /// </summary>
    public class LC002
    {
        /// <summary>
        /// 同样长度
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(-1);

            ListNode cursor = result;

            int carry = 0;//进位

            while (l1 != null && l2 != null)
            {
                int a = l1.val;
                int b = l2.val;

                cursor.next = new ListNode((a + b + carry) % 10);

                cursor = cursor.next;

                carry = (a + b + carry) / 10;

                l1 = l1.next;
                l2 = l2.next;
            }

            if (carry != 0)
            {
                cursor.next = new ListNode(carry);
            }

            return result.next;
        }

        /// <summary>
        /// 不同长度
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode cursor = null;

            //标记是否有进位
            bool isCarry = false;
            //只要有一个链表没有结束，循环继续
            while (l1 != null || l2 != null)
            {
                int val = 0;

                if (l1 != null)
                {
                    val += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    val += l2.val;
                    l2 = l2.next;
                }

                if (isCarry)
                {
                    val += 1;
                }

                if (val >= 10)
                {
                    val -= 10;
                    isCarry = true;
                }
                else
                {
                    isCarry = false;
                }

                if (head == null)
                {
                    head = cursor = new ListNode(val);
                }
                else
                {
                    cursor.next = new ListNode(val);
                    cursor = cursor.next;
                }


                if (isCarry)
                {
                    cursor.next = new ListNode(1);
                }


            }

            return head;

        }

        /// <summary>
        /// 将两个链表 l1 和 l2 全部变为数字做相加后再换回去链表的表示方式
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers3(ListNode l1, ListNode l2)
        {
            //转换为字符串
            int num1 = ListNodeToInt(l1);
            int num2 = ListNodeToInt(l2);
            int sum = num1 + num2;

            ListNode result = IntToListNode(sum);
            return result;
        }

        /// <summary>
        /// listnode转换为int
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public int ListNodeToInt(ListNode l)
        {
            int num = 0;
            int digit = 0;
            while (l != null)
            {
                num += l.val * (int)Math.Pow(10, digit);
                digit++;
                l = l.next;
            }
            return num;
        }

        /// <summary>
        /// int转换为listnode
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public ListNode IntToListNode(int num)
        {
            ListNode head = new ListNode(-1);
            ListNode cursor = null;
            cursor = head;

            int reminder = 0;
            while (num > 0)
            {
                reminder = num % 10;
                cursor.next = new ListNode(reminder);
                cursor = cursor.next;
                num /= 10;
            }

            return head.next;
        }

        /// <summary>
        /// 递归思路
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers4(ListNode l1, ListNode l2)
        {
            ListNode l3 = null;

            if (l1 == null && l2 == null)
            {
                return null;
            }
            else if (l1 == null && l2 != null)
            {
                return l2;
            }
            else if (l1 != null && l2 == null)
            {
                return l1;
            }
            else
            {
                if (l1.val + l2.val < 10)
                {
                    l3 = new ListNode(l1.val + l2.val);
                    l3.next = AddTwoNumbers4(l1.next, l2.next);
                }
                else
                {
                    l3 = new ListNode(l1.val + l2.val - 10);
                    l3.next = AddTwoNumbers4(l1.next, AddTwoNumbers4(l2.next, new ListNode(1)));
                }
            }

            return l3;
        }
    }
}
