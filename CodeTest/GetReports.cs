using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    internal class GetReports
    {
        public void Get(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];

            Dictionary<string, int> userMap = new Dictionary<string, int>();
            Dictionary<int, HashSet<string>> reportHistory = new Dictionary<int, HashSet<string>>();
            Dictionary<int, HashSet<string>> reported = new Dictionary<int, HashSet<string>>();

            for (int i = 0; i < id_list.Length; i++)
            {
                userMap.Add(id_list[i], i);
                reportHistory.Add(i, new HashSet<string>());
                reported.Add(i, new HashSet<string>());
            }

            for (int i = 0; i < report.Length; i++)
            {
                string[] split = report[i].Split(' ');

                if (split[0] == split[1]) continue;

                reportHistory[userMap[split[0]]].Add(split[1]);
                reported[userMap[split[1]]].Add(split[0]);
            }

            for (int i = 0; i < id_list.Length; i++)
            {
                string user = id_list[i];
                foreach (string reportedUsers in reportHistory[userMap[user]])
                {
                    if (reported[userMap[reportedUsers]].Count >= k)
                    {
                        answer[i] += 1;
                    }
                }
            }
        }
    }
}
