namespace Test
{
    public class ArrayAndQueries 
    {
        public int[] Solution(int[] arr, int[,] queries)
        {
            int[] answer = new int[] { };

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int temp = arr[queries[i, 0]];
                arr[queries[i, 0]] = arr[queries[i, 1]];
                arr[queries[i, 1]] = temp;
            }

            answer = arr;

            return answer;
        }
    }
}
