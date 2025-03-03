using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CodeTest;
using System.Text;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int n = 9; //5; //
            int[] info = { 0, 0, 1, 2, 0, 1, 1, 1, 1, 1, 1 }; //{ 2, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 }; //

            ArcheryCompatition archeryCompatition = new ArcheryCompatition();
            Console.WriteLine(string.Join(",", archeryCompatition.Sol(n, info)));
            Console.WriteLine(archeryCompatition.SearchCnt);
        }
    }
}
