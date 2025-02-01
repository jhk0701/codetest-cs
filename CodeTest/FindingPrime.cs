namespace Test
{
    class FindingPrime
    {
        public int Count { get; private set; }

        public FindingPrime(string numbers)
        {
            HashSet<ulong> primes = new HashSet<ulong>();
            List<char> nums = new List<char>();
            for (int i = 0; i < numbers.Length; i++)
                nums.Add(numbers[i]);

            Search("", nums, ref primes);

            Count = primes.Count;
        }

        void Search(string str, List<char> num, ref HashSet<ulong> prime)
        {
            string prevStr = str;
            List<char> prevNum = new List<char>(num);

            for (int i = 0; i < num.Count; i++)
            {
                str += num[i];
                num.RemoveAt(i);

                ulong parsed = ulong.Parse(str);
                if (IsPrime(parsed))
                    prime.Add(parsed);

                Search(str, num, ref prime);

                str = prevStr;
                num = new List<char>(prevNum);
            }
        }

        bool IsPrime(ulong val)
        {
            if (val == 1 || val == 0)
                return false;

            for (ulong i = 2; i * i <= val; i++)
            {
                if (val % i == 0)
                    return false;
            }

            return true;
        }
    }
}
