using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int[] el = { 7, 9, 1, 1, 4 };

            CountOfContiniousPartialSum sol = new CountOfContiniousPartialSum();
            Console.WriteLine(sol.Sol(el));
        }
    }
}
