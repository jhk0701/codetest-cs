namespace Test
{
    internal partial class Program
    {
        public class FunctionDevelop
        {
            public int[] Answer { get; private set; }
            public FunctionDevelop(int[] progresses, int[] speeds) 
            {
                Queue<int> order = new Queue<int>();
                List<int> release = new List<int>();

                for (int i = 0; i < progresses.Length; i++)
                    order.Enqueue(i);

                while (order.Count > 0)
                {
                    for (int i = 0; i < speeds.Length; i++)
                        progresses[i] = Math.Min(100, speeds[i] + progresses[i]);

                    int todayRelease = 0;
                    while (order.TryPeek(out int id) && progresses[id] == 100)
                    {
                        order.Dequeue();
                        todayRelease++;
                    }

                    if (todayRelease > 0)
                        release.Add(todayRelease);
                }

                Answer = release.ToArray();
            }
        }
    }
}
