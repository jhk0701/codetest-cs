using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CodeTest;
using System.Drawing;
using System.Threading;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            int[] arr = st.Reverse().ToArray();

            Console.WriteLine(string.Join("", arr));
        }
    }
}
