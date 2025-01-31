namespace Test
{
    internal partial class Program
    {
        public class Example 
        {
            int[][] students;

            public Example() 
            {
                students = new int[][] 
                {
                    new int[]{ 1, 2, 3, 4, 5 },
                    new int[]{ 2, 1, 2, 3, 2, 4, 2, 5 },
                    new int[]{ 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }
                };
            }

            public int[] Sol1(ref int[] answers) 
            {
                Dictionary<int, int> scores = new Dictionary<int, int>();
                List<int> result = new List<int>();
                for (int i = 0; i < students.Length; i++)
                {
                    int score = GetScore(ref students[i], ref answers);
                    scores.Add(i + 1, score);
                    result.Add(i + 1);
                }

                result.Sort((a, b) => scores[b].CompareTo(scores[a]));
                List<int> ans = new List<int>() { result[0] };
                for (int i = 1; i < result.Count; i++)
                {
                    if (scores[result[0]] == scores[result[i]])
                        ans.Add(result[i]);
                }

                ans.Sort();
                return ans.ToArray();
            }

            public int[] Sol2(ref int[] answers) 
            {
                int[] scores = new int[students.Length];
                for (int i = 0; i < students.Length; i++)
                    scores[i] = GetScore(ref students[i], ref answers);

                int max = scores.Max();
                List<int> maximum = new List<int>();
                for (int i = 0; i < scores.Length; i++)
                {
                    if (scores[i] == max)
                        maximum.Add(i + 1);
                }

                return maximum.ToArray();
            }

            int GetScore(ref int[] pattern, ref int[] answers)
            {
                int score = 0;
                for (int i = 0; i < answers.Length; i++)
                {
                    int idx = i % pattern.Length;

                    if (pattern[idx] == answers[i])
                        score++;
                }

                return score;
            }
        }
    }
}
