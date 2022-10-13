
namespace OnlineMedicalStore
{
    public class DataFiles
    {
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public void Create()
        {
            if(!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            if(!File.Exists("Data/UserData.csv"))
            {
                File.Create("Data/UserData.csv");
            }
            if(!File.Exists("Data/MedicineData.csv"))
            {
                File.Create("Data/MedicineData.csv");
            }
            if(!File.Exists("Data/OrderData.csv"))
            {
                File.Create("Data/OrderData.csv");
            }
        }
    
        public void Write()
        {
            //Writing USERS data to file
            string[] users = new string[userList.Count];

            for(int i=0; i<userList.Count; i++)
            {
                users[i] = userList[i].UserID+","+userList[i].UserName+","+userList[i].Age+","+userList[i].City+","+userList[i].PhoneNumber+","+userList[i].Balance;
            }

            File.WriteAllLines("Data/UserData.csv", users);
            
            //Writing ORDERS data to file
            string[] orders = new string[orderList.Count];
            for(int i=0; i<orderList.Count;i++)
            {
            orders[i] = orderList[i].OrderId+","+orderList[i].UserId+","+orderList[i].MedicineId+","+orderList[i].MedicineCount+","+orderList[i].TotalPrice+","+orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+orderList[i].Status;
            }

            File.WriteAllLines("Data/OrderData.csv", orders);

            //Writing Medicine data to file
            string[] medicine = new string[medicineList.Count];
            for(int i=0; i<medicineList.Count;i++)
            {
                medicine[i] = medicineList[i].MedicineId+","+medicineList[i].MedicineName+","+medicineList[i].AvailableCount+","+medicineList[i].Price+","+medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");
            }

            File.WriteAllLines("Data/MedicineData.csv", medicine);
        }
    
        public void Read()
        {   
            //Read from USER data
            string[] user = File.ReadAllLines("Data/UserData.csv");

            foreach(string data in user)
            {
                userList.Add(new UserDetails(data));
            }

            //Read from ORDER data
            string[] order = File.ReadAllLines("Data/OrderData.csv");
            foreach(string data in order)
            {
                orderList.Add(new OrderDetails(data));
            }

            //Read from MEDICINE data
            string[] medicine = File.ReadAllLines("Data/MedicineData.csv");
            foreach(string data in medicine)
            {
                medicineList.Add(new MedicineDetails(data));
            }

        }
    }
}