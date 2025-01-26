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
            /*
                [1, 2, 3, 4, 5, 6]	            4	      [4, 5, 3, 6, 2, 1]
                [10000,20,36,47,40,6,10,7000]	  30	    [36, 40, 20, 47, 10, 6, 7000, 10000]
            */

            int[] numlist = { 1, 2, 3, 4, 5, 6 };
            int n = 4;

            int[] answer = new IrregularSorting().Solution(ref numlist, n);
        }
    }
}
