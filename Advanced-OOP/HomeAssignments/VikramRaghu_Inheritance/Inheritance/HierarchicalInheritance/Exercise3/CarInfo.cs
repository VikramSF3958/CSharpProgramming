
namespace Exercise3
{
    public class CarInfo
    {
        public string RCBookNumber { get; set; }

        public string EngineNumber { get; set; }

        public string ChasisNumber { get; set; }

        public int Mileage { get; set; }

        public int TankCapacity { get; set; }

        public int Seats { get; set; }

        public int KMDriven { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public CarInfo(string rcNumber, string engineNumber, string chasisNumber, int tankCapacity, int seats, int kmDriven, DateTime dateOfPurchase)
        {
            RCBookNumber = rcNumber;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            TankCapacity = tankCapacity;
            Seats =  seats;
            KMDriven = kmDriven;
            DateOfPurchase = dateOfPurchase;
        }

        public void CalculateMileage()
        {
            Mileage = TankCapacity / KMDriven;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"RCBookNumber: {RCBookNumber}");
            System.Console.WriteLine($"EngineNumber: {EngineNumber}");
            System.Console.WriteLine($"ChasisNumber: {ChasisNumber}");
            System.Console.WriteLine($"Mileage: {Mileage}");
            System.Console.WriteLine($"TankCapacity: {TankCapacity}");
            System.Console.WriteLine($"Seats: {Seats}");
            System.Console.WriteLine($"KMDriven: {KMDriven}");
            System.Console.WriteLine($"DateOfPurchase: {DateOfPurchase}");

        }
    }
}