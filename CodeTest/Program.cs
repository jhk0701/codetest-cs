
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
            int k = 80;
            int[,] dungeons = { {80, 20}, { 50, 40 }, {30, 10} };
            int answer = 0;

            FatigueLevel sol = new FatigueLevel(k, ref dungeons);
            answer = sol.Answer;

            Console.WriteLine(answer);
        }
    }

}
