namespace Test
{
    public class RunningRace 
    {
        public string[] Answer { get; private set; }

        public RunningRace(string[] players, string[] callings) 
        {
            Answer = players;

            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < Answer.Length; i++)
                map.Add(Answer[i], i);

            for (int i = 0; i < callings.Length; i++)
            {
                int idx = map[callings[i]];
                int swapIdx = idx - 1;
                string p1 = Answer[idx];
                string p2 = Answer[swapIdx];

                // 딕셔너리 교체
                map[p1] = swapIdx;
                map[p2] = idx;

                // 배열 교체
                string temp = Answer[idx];
                Answer[idx] = Answer[swapIdx];
                Answer[swapIdx] = temp;
            }
        }
    }

}
