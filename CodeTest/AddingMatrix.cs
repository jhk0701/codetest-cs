namespace Test
{
    public class AddingMatrix 
    {
        public int[,] Answer { get; private set; }

        public AddingMatrix(int[,] arr1, int[,] arr2) 
        {
            Answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
        }

    }
}
