namespace Test
{
    public class SmallestRect
    {
        public int Sol(ref int[,] sizes) 
        {
            int maxX = 0;
            int maxY = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                int x = sizes[i, 0];
                int y = sizes[i, 1];

                maxX = Math.Max(maxX, x > y ? x : y);
                maxY = Math.Max(maxY, x > y ? y : x);
            }


            return maxX * maxY;
        }
    }
}
