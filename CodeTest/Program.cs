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
            string word = "AAAE";
            int answer = 0;

            // Search(ref answer, "A", word, 1);
            DictionaryAEIOU sol = new DictionaryAEIOU();
            sol.Search(ref answer, "", word, 0);
        }
    }
}
