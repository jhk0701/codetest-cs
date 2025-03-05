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
            int[] sequence = { 6, -7, 16, 3, -4 };
                //{ 2, 3, -6, 1, 3, -1, 2, 4 };
            // { -1, 1 }; //{ 1, -1, 1, -1, 1, 1,1,1,1 }; // { 2, 3, -6, 1, 3, -1, 2, 4 };

            ContiniousPulse sol = new ContiniousPulse();
            Console.WriteLine(sol.Sol(sequence));
        }


    }
}
