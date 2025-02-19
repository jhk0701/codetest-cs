namespace Test
{
    public class WorkoutClothes 
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;
            Stack<KeyValuePair<int, char>> st = new Stack<KeyValuePair<int, char>>();

            for (int i = 1; i <= n; i++)
            {
                if (Array.Exists(lost, el => el == i))
                {
                    if (Array.Exists(reserve, el => el == i))
                    {
                        answer++;
                        continue;
                    }

                    if (st.TryPeek(out var pair) && pair.Key == i - 1 && pair.Value == 'R')
                    {
                        st.Pop();
                        answer++;
                    }
                    else
                        st.Push(new KeyValuePair<int, char>(i, 'L'));

                }
                else if (Array.Exists(reserve, el => el == i))
                {
                    answer++;
                    if (st.TryPeek(out var pair) && pair.Key == i - 1 && pair.Value == 'L')
                    {
                        st.Pop();
                        answer++;
                    }
                    else
                        st.Push(new KeyValuePair<int, char>(i, 'R'));
                }
                else
                    answer++;
            }

            return answer;
        }
    }
}
