namespace Test
{
    public class CountOfContiniousPartialSum
    {
        public int Sol(int[] elements) 
        {
            int answer = 0;

            HashSet<int> set = new HashSet<int>();
            for (int i = 1; i <= elements.Length; i++) 
            {
                for (int j = 0; j < elements.Length; j++) 
                {
                    int sum = 0;
                    for (int k = 0; k < i; k++) 
                    {
                        int idx = j + k;
                        idx = idx >= elements.Length ? idx - elements.Length : idx;
                        sum += elements[idx];
                    }

                    set.Add(sum);
                }
            }

            answer = set.Count;

            return answer;        
        }
        
    }
}
