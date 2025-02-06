namespace Test
{
    public class PrivacyPolicy 
    {
        public int[] Answer { get; private set; }
        public PrivacyPolicy(string today, string[] terms, string[] privacies) 
        {
            List<int> answer = new List<int>();

            int todayVal = Date2Value(today);

            Dictionary<string, int> termMap = new Dictionary<string, int>();
            for (int i = 0; i < terms.Length; i++)
            {
                string[] sp = terms[i].Split(' ');
                termMap.Add(sp[0], int.Parse(sp[1]));
            }

            for (int i = 0; i < privacies.Length; i++)
            {
                string[] sp = privacies[i].Split(' ');
                // sp[0] : date
                // sp[1] : term
                int dateVal = Date2Value(sp[0]);
                dateVal += termMap[sp[1]] * 28;

                if (todayVal >= dateVal)
                    answer.Add(i + 1);
            }

            Answer = answer.ToArray();
        }

        int Date2Value(string date)
        {
            string[] sp = date.Split('.');
            int day = 28;
            int month = 12;

            int y = int.Parse(sp[0]) - 2000;
            int m = int.Parse(sp[1]);
            int d = int.Parse(sp[2]);

            return y * month * day + m * day + d;
        }
    }
}
