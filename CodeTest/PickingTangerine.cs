namespace Test
{
    public class PickingTangerine 
    {
        public int Answer { get; private set; }

        public PickingTangerine(int k, int[] tangerine) 
        {
            Answer = 0;

            Dictionary<int, int> sizeMap = new Dictionary<int, int>();
            for (int i = 0; i < tangerine.Length; i++)
            {
                if (sizeMap.ContainsKey(tangerine[i]))
                    sizeMap[tangerine[i]]++;
                else
                    sizeMap.Add(tangerine[i], 1);
            }

            int[] size = sizeMap.Keys.ToArray();
            size = sizeMap.Keys.OrderBy(n => -sizeMap[n]).ToArray();

            for (int i = 0; i < size.Length; i++)
            {
                k -= sizeMap[size[i]];

                Answer++;

                if (k <= 0)
                    break;
            }
        }
    }
}
