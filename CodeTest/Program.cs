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
            string numbers = "123";
            int answer = 0;

            FindingPrime sol = new FindingPrime(numbers);
            Console.WriteLine(sol.Count);
        }
    }
}
