using System.Diagnostics;

namespace CodePractice
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int[] answer = { 1, 2, 3, 4, 5 };
            int[] count = new int[3];

            count[0] = GetCountOfAnswer(ref answer, new int[] { 1, 2, 3, 4, 5 });
            count[1] = GetCountOfAnswer(ref answer, new int[] { 2, 1, 2, 3, 2, 4, 2, 5 });
            count[2] = GetCountOfAnswer(ref answer, new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 });

            int max = count.Max();
            List<int> ans = new List<int>();
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i] + " : " + max);
                if (count[i] == max)
                    ans.Add(i + 1);
            }

            answer = ans.ToArray();
            Console.WriteLine(string.Join(",", answer));
        }

        public static int GetCountOfAnswer(ref int[] answers, int[] arr)
        {
            int cnt = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                int index = i % arr.Length;
                if (answers[i] == arr[index])
                    cnt++;
            }

            return cnt;
        }

    }
}
