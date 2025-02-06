namespace Test
{
    public class MostFrequently
    { 
        public int Answer { get; private set; }
        public MostFrequently(ref int[] array) 
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (map.ContainsKey(array[i]))
                    map[array[i]]++;
                else
                    map.Add(array[i], 1);
            }

            int[] keys = map.Keys.OrderBy(n => -map[n]).ToArray();

            if (keys.Length >= 2 && map[keys[0]] == map[keys[1]])
                Answer = - 1;

            Answer = keys[0];
        }
    }

}
