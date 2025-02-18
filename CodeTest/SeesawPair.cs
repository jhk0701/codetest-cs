namespace Test
{
    public class SeesawPair 
    {
        public long Sol1(int[] weights)
        {
            long answer = 0;

            Array.Sort(weights);
            Console.WriteLine(string.Join(",", weights));

            int i1 = 0, i2 = 0;
            while (i1 < weights.Length - 1)
            {
                for (i2 = i1 + 1; i2 < weights.Length; i2++)
                {
                    if (IsMatched(weights[i1], weights[i2]))
                        answer++;
                }

                i1++;
            }

            return answer;
        }

        bool IsMatched(int a, int b)
        {
            int[] ratio = new int[] { 2, 3, 4 };

            // 방법 1
            for (int i = 0; i < ratio.Length; i++)
            {
                for (int j = 0; j < ratio.Length; j++)
                {
                    if (a * ratio[i] == b * ratio[j])
                        return true;
                }
            }

            float a2 = 1.0f;

            return false;
        }

        public long Sol2(int[] weights) 
        {
            long answer = 0;
            Dictionary<double, long> map = new Dictionary<double, long>();
            for (int i = 0; i < weights.Length; i++)
            {
                double dw = weights[i];
                if (map.ContainsKey(dw))
                    map[dw]++;
                else
                    map.Add(dw, 1);
            }

            double[] keys = map.Keys.ToArray();
            foreach (double k in keys)
            {
                if (map[k] > 1)
                    answer += map[k] * (map[k] - 1) / 2;

                long cnt = 0;

                // 3 / 2
                if (map.TryGetValue(k * 3f / 2f, out cnt))
                    answer += cnt * map[k];
                // 4 / 2
                if (map.TryGetValue(k * 4f / 2f, out cnt))
                    answer += cnt * map[k];
                // 4 / 3
                if (map.TryGetValue(k * 4f / 3f, out cnt))
                    answer += cnt * map[k];
            }

            return answer;
        }

    }
}
