namespace Test
{
    public class DefenceGame 
    {
        public int Sol(int n, int k, ref int[] enemy)
        {
            int answer = 0;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for (int i = 0; i < enemy.Length; i++)
            {
                if (pq.Count < k)
                {
                    pq.Enqueue(enemy[i], enemy[i]);
                    answer++;
                    continue;
                }


                if (enemy[i] > pq.Peek())
                {
                    int small = pq.Dequeue();
                    n -= small;
                    pq.Enqueue(enemy[i], enemy[i]);

                    answer++;
                }
                else
                {
                    n -= enemy[i];

                    if (n >= 0)
                        answer++;
                    else
                        break;
                }
            }


            Console.WriteLine(answer);
            return answer;
        }
    
    }
}
