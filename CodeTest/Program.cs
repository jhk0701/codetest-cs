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
            string t = "A 6";
            string[] sp = t.Split(' ');

            for (int i = 0; i < sp.Length; i++)
                Console.WriteLine(sp[i]);


        }
    }
}
