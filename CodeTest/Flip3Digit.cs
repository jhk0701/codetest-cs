namespace Test
{
    public class Flip3Digit 
    {
        public int Sol(int n) 
        {
            int answer = 0;
            int digit = 3;

            string converted = "";

            while (n >= 3)
            {
                int r = n % 3;
                converted += r;

                n = n / 3;
            }

            converted += n;

            for (int i = 0; i < converted.Length; i++)
            {
                int idx = converted.Length - 1 - i;
                if (converted[idx] == '0')
                    continue;

                answer += int.Parse(converted[idx].ToString()) * (int)Math.Pow(3, i);
            }

            return answer;
        }
    }
}
