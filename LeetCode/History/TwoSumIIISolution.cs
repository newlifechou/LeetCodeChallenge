using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-170 DataStructureDesign
    /// locked
    /// </summary>
    public class TwoSumIIISolution
    {
        /*
        Design and implement a TwoSum class. It should support the following operations: add and find.
        add - Add the number to an internal data structure.
        find - Find if there exists any pair of numbers which sum is equal to the value.
        For example,
        add(1); add(3); add(5);
        find(4) -> true
        find(7) -> false
         */

        //利用list作为容器
        private List<int> list = new List<int>();
        private Dictionary<int,int> dict=new Dictionary<int,int>();

        public void Add(int number)
        {
            list.Add(number);
            //加入list的同时,存入统计到dict
            //key=number,value=count
            if (dict.ContainsKey(number))
            {
                dict.Add(number, dict[number] + 1);
            }
            else
            {
                dict.Add(number, 1);
            }
        }

        public bool Find(int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int cursor = list[i];
                //two sum的思路
                //但是要考虑相等的情况
                int toFind = value - cursor;
                if (cursor != toFind)
                {
                    if (dict.ContainsKey(toFind))
                    {
                        return true;
                    }
                }
                else
                {
                    if (dict[cursor] > 1)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

    }
}
