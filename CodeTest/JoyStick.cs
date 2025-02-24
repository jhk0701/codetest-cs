namespace Test
{
    public class JoyStick
    {
        public int Sol(string name) 
        {
            int answer = 0;
            
            int[] upDown = new int[name.Length];
            int numA = 'A', numZ = 'Z';

            for (int i = 0; i < name.Length; i++) 
            {
                int difA = Math.Abs(name[i] - numA);
                int difZ = Math.Abs(name[i] - numZ - 1);
                upDown[i] = Math.Min(difA, difZ);

                // Console.WriteLine($"{upDown[i]}");
            }

            List<int> list = new List<int>();
            DFS(ref list, ref upDown, 0, 0, upDown.Sum());

            answer = list.Min();

            return answer;
        }

        void Search1() 
        {
            /*
             
            int curIdx = 0;
            while (sum > 0) 
            {
                int cnt = upDown[curIdx];
                answer += cnt;
                upDown[curIdx] = 0;

                sum -= cnt;

                if (sum == 0) 
                    break;

                int next = 0, prev = 0;
                int nextIdx = curIdx, prevIdx = curIdx;
                for (int i = 0; i < upDown.Length; i++) 
                {
                    int idx = nextIdx + i + 1;
                    idx = idx >= upDown.Length ? idx - upDown.Length : idx;

                    next++;

                    if (upDown[idx] > 0)
                    {
                        nextIdx = idx;
                        break;
                    }
                }

                for (int i = 0; i < upDown.Length; i++) 
                {
                    int idx = prevIdx - i - 1;
                    idx = idx < 0 ? upDown.Length + idx : idx;

                    prev++;

                    if(upDown[idx] > 0) 
                    {
                        prevIdx = idx;
                        break;
                    }
                }

                if(next <= prev) 
                {
                    answer += next;
                    curIdx = nextIdx;
                }
                else
                {
                    answer += prev;
                    curIdx = prevIdx;
                }
            }
             */
        }

        void DFS(ref List<int> results, ref int[] arr, int idx, int sum, int remain)
        {
            // 방문 처리
            int val = arr[idx];
            arr[idx] = 0;

            //Console.WriteLine($"visited :: {idx} : {val} : {string.Join(", ", arr)}");

            sum += val;
            remain -= val;

            if (remain <= 0) 
            {
                //Console.WriteLine($"end : {sum}");
                results.Add(sum);

                arr[idx] = val;

                return;
            }

            int cnt = arr.Length;

            // next 찾기
            int nextIdx = idx, nextVal = 0;
            bool nextIsFound = false;
            for (int i = 0; i < cnt; i++) 
            {
                nextIdx++;
                nextIdx = nextIdx >= arr.Length ? 0 : nextIdx;
                //Console.WriteLine($"next :: {nextIdx} : {arr[nextIdx]}");

                nextVal++;

                if (arr[nextIdx] > 0)
                {
                    nextIsFound = true;
                    break;
                }
            }

            // prev 찾기
            int prevIdx = idx, prevVal = 0;
            bool prevIsFound = false;
            for (int i = 0; i < cnt; i++)
            {
                prevIdx--;
                prevIdx = prevIdx < 0 ? arr.Length - 1 : prevIdx;
                //Console.WriteLine($"prev :: {prevIdx} : {arr[prevIdx]}");

                prevVal++;

                if (arr[prevIdx] > 0)
                {
                    prevIsFound = true;
                    break;
                }
            }

            //Console.WriteLine($"next : {nextIsFound} ({nextVal}), prev : {prevIsFound} ({prevVal})");

            if(nextIsFound)
                DFS(ref results, ref arr, nextIdx, sum + nextVal, remain);

            if(prevIsFound)
                DFS(ref results, ref arr, prevIdx, sum + prevVal, remain);

            arr[idx] = val;

            if (!nextIsFound && !prevIsFound)
            {
                // Console.WriteLine($"nothing to visit : {sum}");
                results.Add(sum);
            }
        }


    }
}
