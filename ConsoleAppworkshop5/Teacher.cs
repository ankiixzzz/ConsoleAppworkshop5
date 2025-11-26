namespace DotnetWorkshop
{
    public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        // Virtual method (can be overridden)
        public virtual void Teaching()
        {
            Console.WriteLine($"{Name} teaches in English.");
        }

        // Method that cannot be overridden — use sealed or remove virtual
        public void SalaryInfo()
        {
            Console.WriteLine($"{Name} has a fixed salary structure.");
        }
    }
}
