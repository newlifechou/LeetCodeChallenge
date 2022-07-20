using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 设计hash集合
    /// </summary>
    internal class LC705
    {
    }
    /// <summary>
    /// hash函数设计
    /// 冲突处理：链地址法，开放地址法，再hash法
    /// 扩容
    /// 拉链法
    /// 拉链法是说，我们定义了一个比较小的数组，
    /// 然后使用 hash 方法来把求出 key 应该出现在数组中的位置；
    /// 但是由于不同的 key 在求完 hash 之后，可能会存在碰撞冲突，
    /// 所以数组并不直接保存元素，而是每个位置都指向了一条链表（或数组）用于存储元素。
    /// 求hash在数组中的位置
    /// 在链表中遍历找key
    /// </summary>
    /// 

    //定长拉链
    public class MyHashSet1
    {


        //public MyHashSet1()
        //{

        //}

        //public void Add(int key)
        //{

        //}

        //public void Remove(int key)
        //{

        //}

        //public bool Contains(int key)
        //{

        //}
    }

    /// <summary>
    /// 暴力法
    /// </summary>
    public class MyHashSet2
    {
        private bool[] map = new bool[1000003];
        public MyHashSet2()
        {

        }

        public void Add(int key)
        {
            map[key] = true;
        }

        public void Remove(int key)
        {
            map[key] = false;
        }

        public bool Contains(int key)
        {
            return map[key] == true;
        }
    }


    public class MyHashSet3
    {

        //public MyHashSet3()
        //{

        //}

        //public void Add(int key)
        //{

        //}

        //public void Remove(int key)
        //{

        //}

        //public bool Contains(int key)
        //{

        //}
    }

}
