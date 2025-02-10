namespace Test
{
    public class JumpAndTeleport 
    {
        public int Answer { get; private set; }
        public JumpAndTeleport(int n) 
        {
            int Answer = 1;

            while (n > 1)
            {
                int m = n / 2;
                int r = n % 2;
                if (r > 0)
                    Answer++;
                n = m;
            }
        }
    }
}
