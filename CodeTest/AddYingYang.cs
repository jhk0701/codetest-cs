namespace Test
{
    public class AddYingYang
    {
        public int Answer { get; private set; }

        public AddYingYang(int[] absolutes, bool[] signs) 
        {
            Answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
                Answer += absolutes[i] * (signs[i] ? 1 : -1);
        }

    }
}
