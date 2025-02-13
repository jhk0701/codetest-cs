namespace Test
{
    public class TargetNumber 
    {
        public int Answer { get; private set; }

        public TargetNumber(int[] numbers, int target) 
        {
            Answer = 0;

            DFS(0, 0, ref target, ref numbers);
        }

        void DFS(int sum, int idx, ref int target, ref int[] nums)
        {
            if (idx >= nums.Length)
            {
                if (sum == target)
                    Answer++;

                return;
            }

            DFS(sum + nums[idx], idx + 1, ref target, ref nums);
            DFS(sum - nums[idx], idx + 1, ref target, ref nums);
        }
    }
}
