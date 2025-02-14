namespace Test
{
    public class SplitString 
    {
        public int Answer { get; private set; }

        public SplitString(string s) 
        {
            Answer = 0;

            char c = '1';
            int dup = 0;
            int notDup = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (c == '1')
                {
                    c = s[i];
                    dup = 1;
                    continue;
                }

                if (s[i] == c)
                {
                    dup++;
                    continue;
                }

                notDup++;

                if (dup == notDup)
                {
                    Answer++;
                    dup = 0;
                    notDup = 0;
                    c = '1';
                }
            }

            if (c != '1')
                Answer++;
        }
    }
}
