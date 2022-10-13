
namespace Exercise3
{
    public class Tata : CarInfo
    {
        public string CarModelNumber { get; set; }

        public string CarModelName { get; set; }

        public Tata(string carModelName, string carModelNumber, string rcNumber, string engineNumber, string chasisNumber, int tankCapacity, int seats, int kmDriven, DateTime dateOfPurchase) : base(rcNumber, engineNumber, chasisNumber, tankCapacity, seats, kmDriven, dateOfPurchase)
        {
            CarModelName = carModelName;
            CarModelNumber = carModelNumber;
        }

        public void Show()
        {
            System.Console.WriteLine($"RCBookNumber: {RCBookNumber}");
            System.Console.WriteLine($"EngineNumber: {EngineNumber}");
            System.Console.WriteLine($"ChasisNumber: {ChasisNumber}");
            System.Console.WriteLine($"Mileage: {Mileage}");
            System.Console.WriteLine($"TankCapacity: {TankCapacity}");
            System.Console.WriteLine($"Seats: {Seats}");
            System.Console.WriteLine($"KMDriven: {KMDriven}");
            System.Console.WriteLine($"DateOfPurchase: {DateOfPurchase}");
            System.Console.WriteLine($"CarModelName: {CarModelName}");
            System.Console.WriteLine($"CarModelNumber: {CarModelNumber}");
        }
    }
}