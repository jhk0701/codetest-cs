namespace Test
{
    public class PickAndAdd
    {
        public int[] Answer { get; private set; }
        public PickAndAdd(int[] numbers) 
        {
            HashSet<int> sumSet = new HashSet<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                    sumSet.Add(numbers[i] + numbers[j]);
            }

            Answer = sumSet.OrderBy(n => n).ToArray();
        }
    }

}
