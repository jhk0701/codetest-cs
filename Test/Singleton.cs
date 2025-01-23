namespace Test
{
    internal class Singleton
    {
        static Singleton instance;
        int i = 1;

        private Singleton() {}

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                Console.WriteLine("is Null!");
                instance = new Singleton();
            }

            return instance;
        }
    }
}
