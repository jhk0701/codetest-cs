namespace Test
{
    public class IrregularSorting
    {
        public int[] Solution(ref int[] arr, int n) 
        { 
            return arr.OrderBy(x => Math.Abs(x - n)).ThenByDescending(x => x).ToArray();
        }
    }
}


