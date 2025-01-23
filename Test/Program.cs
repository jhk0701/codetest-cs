namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            return;

            ClassTest ct1 = new SubClassT1();
            ClassTest ct2 = new SubClassT2();

            SubClassT1 subClassT1 = new SubClassT1();
            subClassT1.ID = 6;
            return;

            Console.WriteLine("sub class t1");
            Console.WriteLine(ct1 is SubClassT1);
            Console.WriteLine(ct1 is SubClassT2);
            Console.WriteLine(ct1 is int);

            Console.WriteLine("sub class t2");
            Console.WriteLine(ct2 is SubClassT1);
            Console.WriteLine(ct2 is SubClassT2);
        }

    }
}
