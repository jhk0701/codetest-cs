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
            int[,] arr1 = { { 1,2 }, { 2,3 } };
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
            Console.WriteLine(answer.GetLength(0));
            Console.WriteLine(answer.GetLength(1));

            Console.WriteLine(answer[0,0]);
        }
    }
}
