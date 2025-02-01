namespace Test
{
    internal class Prime
    {
        public bool IsPrimeNaive(int n)
        {
            if (n == 0 || n == 1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public bool IsPrime(ulong val)
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
