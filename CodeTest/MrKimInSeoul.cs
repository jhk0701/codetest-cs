namespace Test
{
    public class MrKimInSeoul 
    {
        public string Sol(string[] seoul) 
        {
            string target = "Kim";

            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == target)
                {
                    return $"김서방은 {i}에 있다";
                }
            }

            return "";
        }
    }
}
