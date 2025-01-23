namespace CodeTest
{
    internal class ConvertBaseN
    {
        string _digitChar = "0123456789abcdef";

        public string ConvertToNewBase(long num, int newBase)
        {
            string result = "";

            while (num > 0)
            {
                long d = num / newBase;
                long r = num % newBase;

                result = result.Insert(0, _digitChar[(int)r].ToString());
                num = d;
            }

            return result;
        }

        public long ConvertToDecimal(string str, int curBase)
        {
            long result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                long n = long.Parse(c.ToString());

                result *= curBase;
                result += n;
                //long digit = (long)MathF.Pow(curBase, i);
                //Console.Write("{0} x {1} = {2}, ", digit, n, digit * n);
                //Console.WriteLine("{0} + {1} = {2}", result, digit * n, result + digit * n);
                //result += n * digit;
            }

            return result;
        }
    }
}
