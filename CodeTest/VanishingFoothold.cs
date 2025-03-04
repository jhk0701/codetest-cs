namespace Test
{
    public class VanishingFoothold 
    {
        int[,] dir = { { 1, -1, 0, 0 }, { 0, 0, 1, -1 } };

        public int Sol(int[,] board, int[] aloc, int[] bloc) 
        {
            int answer = 0;

            Search(ref answer, ref board, ref aloc, ref bloc);

            return answer;
        }

        void Search(ref int result, ref int[,] board, ref int[] a, ref int[] b)
        {
            
        }

    }
}
