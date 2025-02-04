using System.Linq;
using System.Collections.Generic;
using CodeTest;
using System.Collections;
using System.Text;
using System;
using System.Numerics;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int[,] sizes = { {60, 50}, {30, 70}, {60, 30}, {80, 40} };
            
            for (int i = 0; i < sizes.GetLength(0); i++) 
            {
                var a = sizes[i, 0];
                Console.WriteLine(a);
            }
        }
    }
}
