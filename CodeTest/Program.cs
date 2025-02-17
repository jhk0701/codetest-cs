using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CodeTest;
using System.Drawing;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;

            int[] ingredient = { 1, 2, 1, 2, 3, 1, 3, 1 };

            List<int> st = new List<int>();
            int[] order = { 1, 2, 3, 1 };
            int oId = 0;

            for (int i = 0; i < ingredient.Length; i++)
            {
                st.Add(ingredient[i]);

                int top = st.Last();
                if (top == order[oId])
                    oId++;
                else
                    oId = top == order[0] ? 1 : 0;

                if (oId == order.Length)
                {
                    answer++;

                    for (int j = 0; j < order.Length; j++)
                        st.RemoveAt(st.Count - 1);

                    oId = 0;
                    for (int j = 0; j < st.Count; j++) 
                    {
                        if(st[j] == order[oId])
                            oId++;
                        else 
                            oId = 0;
                    }
                }
            }

            Console.WriteLine(answer);
        }

    }
}
