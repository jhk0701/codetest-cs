namespace Test
{
    internal class ClassTest
    {
        public virtual int ID { get; set; }
        public string Name { get; set; }
        public ClassTest() 
        { 

        }
        public ClassTest(int id, string n)
        {
            ID = id;
            Name = n;
        }

        public ClassTest Copy()
        {
            return new ClassTest(ID, Name);
        }
    }

    class SubClassT1 : ClassTest
    {
        public override int ID 
        {
            get { return base.ID; }
            set {
                base.ID = value;
                Console.WriteLine($"Edit in subclass. {base.ID}");
            }
        }
    }

    class SubClassT2 : ClassTest
    {

    }
}
