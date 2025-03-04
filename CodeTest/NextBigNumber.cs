namespace Test
{
    public class NextBigNumber 
    {
        public int Sol(int n) 
        {
            int answer = n;
            int target = CheckAsBinary(n);
            do 
            {
                answer++;
            }
            while (target != CheckAsBinary(answer));

            return answer;        
        }

        int CheckAsBinary(int num) 
        {
            int cnt = 0;

            while (num >= 2) 
            {
                int r = num % 2;
                cnt += r == 1 ? 1 : 0;

                num /= 2;
            }

            cnt += num == 1 ? 1 : 0;

            return cnt;
        }
    }
}
