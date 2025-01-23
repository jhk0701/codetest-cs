namespace CodeTest
{
    internal class GCD
    {
        public GCD(int n, int m)
        {
            Console.WriteLine(GetGreatestCommonDivisor(n, m));
        }

        public int GetGreatestCommonDivisor(int n, int m)
        {
            int big = n > m ? n : m;
            int small = n > m ? m : n;

            int rest = big % small;

            if (rest > 0)
                return GetGreatestCommonDivisor(small, rest);
            else
                return small;
        }
    }
}
