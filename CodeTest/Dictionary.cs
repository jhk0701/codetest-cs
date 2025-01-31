namespace Test
{
    public class DictionaryAEIOU
    {
        char[] init = new char[] { 'A', 'E', 'I', 'O', 'U' };
        bool isComplete = false;

        public void Search(ref int cnt, string chars, string target, int idx)
        {
            Console.WriteLine($"{chars} : {cnt}");

            if (chars.Equals(target))
            {
                isComplete = true;
                return;
            }

            if (chars.Length >= 5 || isComplete)
                return;

            string prev = chars;
            for (int i = 0; i < init.Length; i++)
            {
                if (isComplete) return;

                cnt++;
                chars += init[i];
                Search(ref cnt, chars, target, idx + 1);
                chars = prev;
            }
        }
    }
}
