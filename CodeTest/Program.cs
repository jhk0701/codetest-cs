using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CodeTest;

namespace Test
{
    internal partial class Program
    {
        public class SortedQ : IComparer<KeyValuePair<int, int>>
        {
            public int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return x.Value.CompareTo(y.Value);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
