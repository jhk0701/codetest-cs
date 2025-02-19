namespace Test
{
    public class MakingBigNumber 
    {
        public string solution(string number, int k)
        {
            string answer = "";
            int cnt = number.Length - k;
            Stack<int> numStack = new Stack<int>();

            for (int i = 0; i < number.Length; i++)
            {
                int num = int.Parse(number[i].ToString());
                int remain = cnt - numStack.Count;

                if (remain <= number.Length - (1 + i))
                {
                    while (numStack.TryPeek(out int val))
                    {
                        if (remain > number.Length - (1 + i))
                            break;

                        if (val < num)
                        {
                            numStack.Pop();
                            remain = cnt - numStack.Count;
                        }
                        else
                            break;
                    }
                }

                if (remain > 0)
                    numStack.Push(num);
            }

            int[] arr = numStack.Reverse().ToArray();
            answer = string.Join("", arr);
            return answer;
        }
    }
}
