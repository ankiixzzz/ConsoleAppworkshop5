//namespace DotnetWorkshop
//{
//    public class Vehicle
//    {
//        public string Brand { get; set; }
//        public int Speed { get; set; }

//        public Vehicle(string brand, int speed)
//        {
//            Brand = brand;
//            Speed = speed;
//        }

//        public void Start()
//        {
//            Console.WriteLine($"{Brand} is starting...");
//        }

//        public void Stop()
//        {
//            Console.WriteLine($"{Brand} has stopped.");
//        }

//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
//        }
//    }
//}
namespace DotnetWorkshop
{
    public abstract class Vehicle
    {
        // Abstract methods
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
