using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CodeTest;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            a.Add(1);
            foreach (int item in a)
            {
                
            }

            Console.WriteLine(a.ElementAt(0));
        }
    }
}
