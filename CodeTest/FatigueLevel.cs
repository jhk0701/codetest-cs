namespace Test
{
    public class FatigueLevel 
    {
        public int Answer { get; private set; }

        public FatigueLevel(int k, ref int[,] dungeons) 
        {
            Answer = 0;
            DFS(k, 0, new bool[dungeons.GetLength(0)], ref dungeons);
        }

        void DFS(int k, int cnt, bool[] visited, ref int[,] dungeons)
        {
            for (int i = 0; i < dungeons.GetLength(0); i++) 
            {
                if(k >= dungeons[i, 0] && !visited[i])
                {
                    visited[i] = true;

                    DFS(k - dungeons[i, 1], cnt + 1, visited, ref dungeons);

                    visited[i] = false;
                }
                else
                    Answer = Math.Max(Answer, cnt);
            }
        }
    }

}
