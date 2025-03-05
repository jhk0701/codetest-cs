namespace Test
{
    public class ContiniousPulse 
    {
        public long Sol(int[] sequence) 
        {
            long answer = 0;
            long sum = 0;
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < sequence.Length; i++)
            {
                int sig = Process(sequence[i], ref stack);
                if (stack.Count > 0 &&  stack.Peek() == sig) 
                {
                    Console.WriteLine("Reset");
                    answer = Math.Max(answer, sum); // stop
                    sum = Math.Abs(sequence[i]); // reset
                }
                else
                    sum += Math.Abs(sequence[i]);

                stack.Push(sig);

                Console.WriteLine($"sum : {sum}");
            }

            answer = Math.Max(answer, sum);

            return answer;
        }

        int Process(int num, ref Stack<int> st)
        {
            if (num == 0)
            {
                if (st.TryPeek(out int top))
                    return top * -1;
                else
                    return 0;
            }

            return num / Math.Abs(num);
        }
    }
}
