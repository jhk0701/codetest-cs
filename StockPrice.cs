using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class StockPrice
    {
        int[] result;

        public StockPrice(ref int[] arr) 
        {
            result = new int[arr.Length];
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(st.Count == 0)
                    st.Push(i);

                while (st.Count > 0 && arr[i] < arr[st.Peek()])
                {
                    int idx = st.Pop();
                    result[idx] = i - idx;
                }

                st.Push(i);
            }

            int lastIdx = arr.Length - 1;
            while (st.Count > 0)
            {
                int idx = st.Pop();
                result[idx] = lastIdx - idx;
            }

            
        }

        public int[] Get() { return result; }
    }
}
