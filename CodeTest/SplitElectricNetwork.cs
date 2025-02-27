namespace Test
{
    public class SplitElectricNetwork 
    {
        public int Sol(int n, int[,] wires)
        {
            List<int> result = new List<int>();
            Dictionary<int, HashSet<int>> setMap = new Dictionary<int, HashSet<int>>();

            for (int i = 1; i <= n; i++)
                setMap.Add(i, new HashSet<int>());

            for (int i = 0; i < wires.GetLength(0); i++)
                AddMap(wires[i, 0], wires[i, 1], ref setMap);

            for (int i = 0; i < wires.GetLength(0); i++) 
            {
                int num1 = wires[i, 0], num2 = wires[i, 1];
                RemoveMap(num1, num2, ref setMap);

                DFS(n, ref setMap, ref result);

                AddMap(num1, num2, ref setMap);
            }

            return result.Min();
        }

        void AddMap(int num1, int num2, ref Dictionary<int, HashSet<int>> map) 
        {
            map[num1].Add(num2);
            map[num2].Add(num1);
        }

        void RemoveMap(int num1, int num2, ref Dictionary<int, HashSet<int>> map) 
        {
            map[num1].Remove(num2);
            map[num2].Remove(num1);
        }

        void DFS(int n, ref Dictionary<int, HashSet<int>> map, ref List<int> result)
        {
            Stack<int> st = new Stack<int>();
            bool[] isVisited = new bool[n + 1];
            List<int> dfs = new List<int>();

            for(int k = 1; k <= n; k++) 
            {
                if (isVisited[k]) 
                    continue;

                int cnt = 0;
                st.Push(k);

                while (st.Count > 0)
                {
                    int top = st.Pop();

                    isVisited[top] = true;
                    cnt++;

                    foreach (int i in map[top])
                    {
                        if (!isVisited[i])
                            st.Push(i);
                    }
                }

                dfs.Add(cnt);
            }

            result.Add(Math.Abs(dfs[0] - dfs[1]));
        }


    }
}
