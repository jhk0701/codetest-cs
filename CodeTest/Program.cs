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
            string[,] tickets = { { "ICN", "AAA" }, { "DDD", "ICN" }, { "ICN", "DDD" } };
            // {{"ICN", "AAA"}, {"DDD", "ICN"}, {"ICN", "DDD"}}
            // {{ "ICN", "JFK"}, {"HND", "IAD"}, {"JFK", "HND"}};
            // {{"ICN", "SFO"}, {"ICN", "ATL"}, {"SFO", "ATL"}, {"ATL", "ICN"}, {"ATL","SFO"}}

            TravelPath sol = new TravelPath(ref tickets);
            Console.WriteLine(string.Join(",", sol.Answer));
        }
    }

}
