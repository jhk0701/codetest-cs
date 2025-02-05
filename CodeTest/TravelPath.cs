namespace Test
{
    public class TravelPath 
    {
        public string[] Answer => results.OrderBy(n => string.Concat(n)).First().ToArray();
        public List<List<string>> results;

        public TravelPath(ref string[,] tickets) 
        {
            results = new List<List<string>>();

            // 그래프 구성
            Dictionary<string, List<string>> connect = new Dictionary<string, List<string>>();
            Dictionary<string, int> ticketCount = new Dictionary<string, int>();

            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                if (connect.ContainsKey(tickets[i, 0]))
                    connect[tickets[i, 0]].Add(tickets[i, 1]);
                else
                    connect.Add(tickets[i, 0], new List<string>() { tickets[i, 1] });

                if(!connect.ContainsKey(tickets[i, 1]))
                    connect.Add(tickets[i, 1], new List<string>());

                string tickStr = $"{tickets[i, 0]}-{tickets[i, 1]}";
                if (ticketCount.ContainsKey(tickStr))
                    ticketCount[tickStr]++;
                else
                    ticketCount.Add(tickStr, 1);
            }

            // DFS
            DFS(new List<string>() { "ICN" }, tickets.GetLength(0), ticketCount, ref connect);
        }

        void DFS(List<string> path, int ticketCnt, Dictionary<string, int> ticketCount, ref Dictionary<string, List<string>> mapping)
        {
            if (ticketCnt <= 0)
            {
                results.Add(path);
                return;
            }

            string port = path[path.Count - 1];

            int cnt = mapping[port].Count;
            for (int i = 0; i < mapping[port].Count; i++)
            {
                string tickName = $"{port}-{mapping[port][i]}";
                if (ticketCount[tickName] == 0)
                    continue;

                List<string> nextPath = new List<string>(path);
                nextPath.Add(mapping[port][i]);

                Dictionary<string, int> newTickCnt = new Dictionary<string, int>(ticketCount);
                newTickCnt[tickName] -= 1;
                
                DFS(nextPath, ticketCnt - 1, newTickCnt, ref mapping);
            }
        }
    }

}
