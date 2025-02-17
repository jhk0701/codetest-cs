namespace Test
{
    public class BuildingHamburger 
    {

        public int Sol1(ref int[] ingredient)
        {
            int answer = 0;

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
                        if (st[j] == order[oId])
                            oId++;
                        else
                            oId = 0;
                    }
                }
            }

            return answer;
        }
        
        public int Sol2(ref int[] ingredient) 
        {
            int answer = 0;

            int[] order = { 1, 2, 3, 1 };

            Stack<int> st = new Stack<int>();
            Stack<int> oIdSt = new Stack<int>();

            int oId = 0;

            for (int i = 0; i < ingredient.Length; i++)
            {
                st.Push(ingredient[i]);
                int top = st.Peek();

                if (top == order[oId])
                    oId++;
                else
                {
                    oId = 0;
                    if (top == order[oId])
                        oId++;
                }

                oIdSt.Push(oId);

                if (oId == order.Length)
                {
                    // 완성된 경우
                    answer++;

                    for (int j = 0; j < order.Length; j++)
                    {
                        st.Pop();
                        oIdSt.Pop();
                    }

                    if (oIdSt.Count > 0)
                        oId = oIdSt.Peek();
                    else
                        oId = 0;
                }
            }

            return answer;
        }
    }
}
