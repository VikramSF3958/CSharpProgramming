
namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int _medicineId = 100;

        public string MedicineId { get; set; }

        public string MedicineName { get; set; }

        public int AvailableCount { get; set; }

        public double Price { get; set; }

        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails()
        {

        }

        public MedicineDetails(string medicineName, int count, double price, DateTime doe)
        {   
            _medicineId++;
            MedicineId = "MD"+_medicineId;
            MedicineName = medicineName;
            AvailableCount = count;
            Price = price;
            DateOfExpiry = doe;
        }

        public MedicineDetails(string data)
        {
            string[] values = data.Split(',');

            _medicineId = int.Parse(values[0].Remove(0,2));
            MedicineId = values[0];
            MedicineName = values[1];
            AvailableCount = int.Parse(values[2]);
            Price = int.Parse(values[3]);
            DateOfExpiry = DateTime.ParseExact(values[4], "dd/MM/yyyy", null);
        }
    }
}