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

            Search(Result, Simulate(Result));
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

        void Search(int lv, bool isLeft)
        {
            Console.WriteLine($"Search Start");

            // 이분탐색 시도          
            if (isLeft)
                maxLv = lv;
            else
                minLv = lv;

            int nextLv = ((isLeft ? minLv : maxLv) + lv) / 2;
            bool newResult = Simulate(nextLv);

            Console.WriteLine($"[{minLv}, {maxLv}] {lv}, {isLeft} => {nextLv}, {newResult}");
            
            Result = newResult ? nextLv : Result;

            if (maxLv - minLv > 1)
                Search(nextLv, newResult);
        }

    }
}
