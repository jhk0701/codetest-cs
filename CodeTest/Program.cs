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
            SplitElectricNetwork split = new SplitElectricNetwork();

            int n = 7;
            int[,] wires = { {1,2},{2,7},{3,7},{3,4},{4,5},{6,7} };

            Console.WriteLine(split.Sol(n, wires));
        }
    }
}
