using System.Linq;
using System.Collections.Generic;
using CodeTest;
using System.Collections;
using System.Text;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args) 
        {
            // ["sun", "bed", "car"]	1	["car", "bed", "sun"]
            // ["abce", "abcd", "cdx"]	2
            string[] strings = { "abce", "abcd", "cdx" };
            int n = 1;

            strings = strings.OrderBy(s => s[n]).ThenBy(s=>s).ToArray();
            
            Console.WriteLine(string.Join(", ", strings));
        }
    }
}
