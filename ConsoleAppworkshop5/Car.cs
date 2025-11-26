namespace DotnetWorkshop
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, int speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
