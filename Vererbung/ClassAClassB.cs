namespace Ips.Vererbung.Allgemein
{
    public class ClassA
    {
        public ClassA() : this(null, null) {}
        public ClassA(string name, string firstname)
        {
            Name = name;
            Firstname = firstname;
        }

        public int Count { set; get; } = 0;
        public string Name { set; get; } = null;
        public string Firstname { get; set; } = null;

        public int Increment(int Interval)
        {
            return Count += Interval;
        }

        public string GetFullName()
        {
            return string.Format($"{Firstname} {Name}");
        }
    }

    public class ClassB : ClassA
    {
        public string City { get; set; } = null;

        public ClassB() : this(null) { }
        public ClassB(string city)
        {
            City = city;
        }

        public string GetFullNameAndCity()
        {
            return string.Format("{0} {1} wohnt in {2}", Firstname, Name, City);
        }
    }
}
