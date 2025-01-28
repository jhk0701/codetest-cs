namespace Test
{
    public class StringSortingInMyWay() 
    {
        public string[] Sort(ref string[] strings, int n) 
        {
            return strings.OrderBy(s => s[n]).ThenBy(s => s).ToArray();
        }
    }
}
