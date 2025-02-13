namespace Test
{
    public class InterceptionSystem
    {
        public int Answer { get; private set; }
        public int[,] targets;


        public void Sol1(int[,] targets) 
        {

            Answer = 0;
            List<int> sorted = Enumerable.Range(0, targets.GetLength(0))
                            .OrderBy(n => targets[n, 1] - targets[n, 0])
                            .ToList();

            while (sorted.Count > 0)
            {
                int id = sorted[0];
                int diff = targets[id, 1] - targets[id, 0];

                int max = 0;
                Dictionary<int, List<int>> opt = new Dictionary<int, List<int>>();

                for (int i = 0; i < diff; i++)
                {
                    opt.Add(i, new List<int>());
                    float pos = targets[id, 0] + 0.5f * (i + 1);

                    for (int j = 0; j < sorted.Count; j++)
                    {
                        if (targets[sorted[j], 0] < pos && targets[sorted[j], 1] > pos)
                            opt[i].Add(j);
                    }

                    if (opt[max].Count < opt[i].Count)
                        max = i;
                }

                Answer++;
                if (opt[max].Count > 0)
                {
                    for (int i = 0; i < opt[max].Count; i++)
                    {
                        int lastId = opt[max].Count - 1 - i;
                        int removeId = opt[max][lastId];
                        sorted.RemoveAt(removeId);
                    }

                }
                else
                    sorted.RemoveAt(0);
            }
        }

        public void Sol2(int[,] targets) 
        {
            int Answer = 0;
            int[] sorted = Enumerable.Range(0, targets.GetLength(0))
                    .OrderBy(n => targets[n, 1])
                    .ToArray();

            int curIdx = 0;
            for (int i = 0; i < sorted.Length; i++)
            {
                if (targets[sorted[curIdx], 1] <= targets[sorted[i], 0])
                {
                    curIdx = i;
                    Answer++;
                }
            }

            Answer++;
        }
    }   
}
