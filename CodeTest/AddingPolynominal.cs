namespace Test
{
    class AddingPolynominal() 
    {
        public string Add(string str) 
        {
            string[] split = str.Split(" ");

            int x = 0;
            int n = 0;

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] == "+")
                    continue;

                if (split[i].Contains("x"))
                {
                    if (split[i].Length == 1)
                        x += 1;
                    else
                    {
                        string sub = split[i].Substring(0, split[i].Length - 1);
                        x += int.Parse(sub);
                    }
                }
                else
                    n += int.Parse(split[i]);
            }

            string answer = x > 0 ? x > 1 ? $"{x}x" : "x" : "";
            if (answer != "")
                answer += n > 0 ? $" + {n}" : "";
            else
                answer += n > 0 ? $"{n}" : "";
            answer = answer == "" ? "0" : answer;

            return answer;
        }
    }
}
