namespace Test
{
    
            //int n = 9; //5;
            //int[] info = { 0, 0, 1, 2, 0, 1, 1, 1, 1, 1, 1 }; //{ 2, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 };

            //ArcheryCompatition archeryCompatition = new ArcheryCompatition();
            //Console.WriteLine(string.Join(",", archeryCompatition.Sol(n, info)));
            //Console.WriteLine(archeryCompatition.SearchCnt);

    public class ArcheryCompatition 
    {
        public int SearchCnt;

        bool isWin;
        int diff;
        public int[] Result;

        public int[] Sol(int n, int[] info)
        {
            SearchCnt = 0;

            isWin = false;
            diff = int.MinValue;
            Result = new int[info.Length];

            int[] arr = new int[info.Length];
            Search(0, n, ref arr, ref info, 0);

            return isWin ? Result : new int[]{-1};
        }

        void Search(int idx, int cnt, ref int[] arr, ref int[] apeach, int score)
        {
            SearchCnt++;
            Console.WriteLine($"{SearchCnt} : {string.Join(",", arr)}");

            if (idx >= cnt)
            {
                if (IsWin(ref arr, ref apeach, out int newDiff))
                {
                    if (newDiff > diff || (newDiff == diff && Compare(ref arr, ref Result))) 
                    {
                        isWin = true;
                        diff = newDiff;
                        Result = arr.ToArray();
                    }
                }

                return;
            }

            for(int i = 0; i < arr.Length; i++) 
            {
                arr[i] += 1;

                int newScore = CalcScore(ref arr, ref apeach);
                Search(idx + 1, cnt, ref arr, ref apeach, newScore);

                arr[i] -= 1;
            }

            Console.WriteLine("Break");
        }

        bool IsWin(ref int[] ryan, ref int[] apeach, out int diff) 
        {
            int ryanNum = 0, apeachNum = 0;

            for (int i = 0; i < apeach.Length; i++) 
            {
                if (ryan[i] == 0 && apeach[i] == 0)
                    continue;

                if (ryan[i] > apeach[i])
                    ryanNum += 10 - i;
                else
                    apeachNum += 10 - i;
            }

            bool result = ryanNum > apeachNum;
            diff = result ? ryanNum - apeachNum : 0;
            return result;
        }

        int CalcScore(ref int[] ryan, ref int[] apeach) 
        {
            int ryanNum = 0;

            for (int i = 0; i < apeach.Length; i++)
            {
                if (ryan[i] == 0 && apeach[i] == 0)
                    continue;

                if (ryan[i] > apeach[i])
                    ryanNum += 10 - i;
            }

            return ryanNum;
        }
        
        bool Compare(ref int[] arr1, ref int[] arr2) 
        {
            for (int i = 0; i < arr1.Length; i++) 
            {
                int idx = arr1.Length - 1 - i;

                if (arr1[idx] > arr2[idx])
                    return true;
                else if (arr1[idx] == arr2[idx])
                    continue;
            }

            return false;
        }
    }
}
