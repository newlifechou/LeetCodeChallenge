using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 循环双端数列
    /// </summary>
    internal class LC641
    {
    }
    /// <summary>
    /// 数组实现
    /// </summary>
    public class MyCircularDeque
    {
        //tail==head means null
        //tail+1=head
        private int capacity;
        private int[] queue;
        //插入时，head-1，再赋值
        //删除时，head+1
        private int front;
        //插入时，再赋值,再rear+1
        //删除时，rear-1
        private int rear;
        //因为有循环的出现，要特别注意处理数组下标可能越界的情况。
        //指针后移的时候，下标 + 1+1，要取模；
        //指针前移的时候，为了循环到数组的末尾，需要先加上数组的长度，然后再对数组长度取模。

        public MyCircularDeque(int k)
        {
            //数组大小是给定大小+1，因为rear所指向的位置始终是空的
            capacity = k + 1;
            queue = new int[k];
            front = rear = 0;
        }

        public bool InsertFront(int value)
        {
            if (IsFull())
                return false;
            front = (front - 1 + capacity) % capacity;
            queue[front] = value;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull())
                return false;
            queue[rear] = value;
            rear = (rear + 1) % capacity;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty())
                return false;
            front = (front + 1) % capacity;
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty())
                return false;
            rear = (rear - 1 + capacity) % capacity;
            return true;
        }

        public int GetFront()
        {
            if (IsEmpty())
                return -1;
            return queue[front];
        }

        public int GetRear()
        {
            if (IsEmpty())
                return -1;
            return queue[(rear - 1 + capacity) % capacity];
        }

        public bool IsEmpty()
        {
            return front == rear;
        }

        public bool IsFull()
        {
            return (rear + 1) % capacity == front;
        }
    }
}
