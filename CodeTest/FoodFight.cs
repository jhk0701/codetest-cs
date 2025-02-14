using System.Text;

namespace Test
{
    public class FoodFight 
    {
        public string Answer { get; private set; }
        public FoodFight(int[] food) 
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < food.Length; i++)
            {
                int cnt = food[i] / 2;
                for (int j = 0; j < cnt; j++)
                    sb.Append(i);
            }

            string line = sb.ToString();
            char[] arr = line.ToCharArray();
            Array.Reverse(arr);

            Answer = string.Concat(line, "0", new string(arr));
        }
    }
}
