using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 设计循环队列
    /// 收尾相接的环
    /// </summary>
    internal class LC622
    {
    }

    /// <summary>
    /// 利用数组
    /// 不考虑线程安全
    /// queue
    /// headIndex
    /// count
    /// capacity
    /// tailIndex
    /// </summary>
    public class MyCircularQueue1
    {
        private int[] queue;
        private int headIndex;
        private int count;
        private int capacity;

        public MyCircularQueue1(int k)
        {
            queue = new int[k];
            capacity = k;
            headIndex = 0;
            count = 0;
        }

        public bool EnQueue(int value)
        {
            if (count == capacity)
                return false;
            queue[(headIndex + count) % capacity] = value;
            count++;
            return true;
        }

        public bool DeQueue()
        {
            if (count == 0)
                return false;
            headIndex = (headIndex + 1) % capacity;
            count--;
            return true;
        }

        public int Front()
        {
            if (count == 0)
                return -1;
            return queue[headIndex];
        }

        public int Rear()
        {
            if (count == 0)
                return -1;
            int tailIndex = (headIndex + count - 1) % capacity;
            return queue[tailIndex];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacity;
        }
    }


    /// <summary>
    /// Node
    /// </summary>
    public class Node
    {
        public int val;
        public Node next;
        public Node(int value)
        {
            val = value;
            next = null;
        }
    }


    /// <summary>
    /// 单链表
    /// </summary>
    public class MyCircularQueue2
    {
        private Node head, tail;
        private int count;
        private int capacity;
        public MyCircularQueue2(int k)
        {
            capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (count == capacity)
                return false;
            Node newNode = new Node(value);
            if (count == 0)
                head = tail = newNode;
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            count++;
            return true;
        }

        public bool DeQueue()
        {
            if (count == 0)
                return false;
            head = head.next;
            count--;
            return true;
        }

        public int Front()
        {
            if (count == 0)
                return -1;
            else
                return head.val;
        }

        public int Rear()
        {
            if (count == 0)
                return -1;
            else
                return tail.val;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacity;
        }
    }

}
