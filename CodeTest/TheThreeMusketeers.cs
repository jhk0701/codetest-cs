namespace Test
{
    public class TheThreeMusketeers 
    {
        public int Sol(int[] number) 
        {
            int answer = 0;

            int i0 = 0, i1 = 0, i2 = 0;
            for (i0 = 0; i0 < number.Length - 2; i0++)
            {
                for (i1 = i0 + 1; i1 < number.Length - 1; i1++)
                {
                    for (i2 = i1 + 1; i2 < number.Length; i2++)
                    {
                        int sum = number[i0] + number[i1] + number[i2];
                        if (sum == 0)
                            answer++;
                    }
                }
            }

            return answer;
        }
    }
}
