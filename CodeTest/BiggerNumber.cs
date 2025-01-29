namespace Test
{
    class BiggerNumber
    {
        public string Solution(ref int[] numbers) 
        {
            string[] strs = new string[numbers.Length];

            for (int i = 0; i < strs.Length; i++)
                strs[i] = numbers[i].ToString();

            Array.Sort(strs, (a, b) => (b + a).CompareTo(a + b));

            string answer = string.Join("", strs);

            return answer[0] == '0' ? "0" : answer;
        }
    }
}
