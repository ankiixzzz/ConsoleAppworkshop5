namespace DotnetWorkshop
{
    public class Motorcycle : Vehicle
    {
        public bool HasCarrier { get; set; }

        public Motorcycle(string brand, int speed, bool hasCarrier) : base(brand, speed)
        {
            HasCarrier = hasCarrier;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}
