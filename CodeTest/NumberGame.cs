namespace Test
{
    public class NumberGame 
    {
        public int Sol(ref int[] A, ref int[] B) 
        {
            int answer = 0;

            List<int> listB = B.Order().ToList();
            for (int i = 0; i < A.Length; i++)
            {
                if (BinarySearch(A[i], ref listB))
                    answer++;
            }

            return answer;
        }

        bool BinarySearch(int target, ref List<int> list)
        {
            if (list[list.Count - 1] <= target)
            {
                list.RemoveAt(0);
                return false;
            }

            int s = 0, e = list.Count - 1;
            int m = 0;
            while (s <= e)
            {
                m = (s + e) / 2;

                if (list[m] <= target)
                    s = m + 1;
                else
                    e = m - 1;
            }

            list.RemoveAt(e + 1);

            return true;
        }
    }
}
