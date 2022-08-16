﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1656
    {
    }
    public class OrderedStream
    {
        private string[] stream;
        private int ptr;
        public OrderedStream(int n)
        {
            stream = new string[n + 1];
            ptr = 1;
        }

        public IList<string> Insert(int idKey, string value)
        {
            stream[idKey] = value;
            IList<string> res = new List<string>();
            while (ptr < stream.Length && stream[ptr] != null)
            {
                res.Add(stream[ptr]);
                ptr++;
            }
            return res;
        }
    }


}
