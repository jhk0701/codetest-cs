using System;
using System.Collections.Generic;

namespace Test
{
    internal class PuzzleGameChallenge
    {
        public int Result { get; private set; } = 0;
        int[] diff, time;
        long lim;

        int maxLv = int.MinValue;
        int minLv = 1;

        public PuzzleGameChallenge(ref int[] diffs, ref int[] times, long limit) 
        {
            diff = diffs;
            time = times;
            lim = limit;

            int sum = 0;
            foreach (int el in diff) 
            {
                sum += el;
                maxLv = Math.Max(el, maxLv);
            }

            Result = sum / diffs.Length;

            Search(Result);
        }

        bool Simulate(int level) 
        {
            long totalTime = 0;
            
            for (int i = 0; i < diff.Length; i++)
            {
                int trial = Math.Max(diff[i] - level, 0);
                int timeCur = time[i];
                int timePrev = i > 0 ? time[i - 1] : time[0];

                totalTime += trial > 0 ? (trial * (timePrev + timeCur) + timeCur) : timeCur;
            }

            return lim >= totalTime;
        }

        void Search(int lv)
        {
            // Console.WriteLine($"Search Start");

            int nextLv = lv;
            bool newResult = false;

            // 이분탐색 시도
            do
            {
                newResult = Simulate(nextLv);

                if (newResult)
                    maxLv = nextLv - 1;
                else
                    minLv = nextLv + 1;

                nextLv = (maxLv + minLv) / 2;
                // Console.WriteLine($"[{minLv}, {maxLv}] => {nextLv}, {newResult}");
            }
            while (maxLv >= minLv);

            Result = nextLv + 1;
        }

    }
}
