namespace OnlineMedicalStore;

class Program 
{
    public static void Main(string[] args)
    {
        DataFiles datas = new DataFiles();

        datas.Read();
        //Calling the Main Menu
        MainMenu.MainMenuMethod();

        //Default();

        //datas.Create();
        datas.Write();
    }

    public static void Default()
    {
        UserDetails user = new UserDetails("Ravi", 33, "Chennai", 9877774440, 400);
        DataFiles.userList.Add(user);

        UserDetails user1 = new UserDetails("Basakaran", 33, "Chennai", 8847757470, 500);
        DataFiles.userList.Add(user1);

       //Medicine
        MedicineDetails obj = new MedicineDetails("Paracitamol", 40, 5, new DateTime(2022, 06, 30));
        DataFiles.medicineList.Add(obj);

        MedicineDetails obj1 = new MedicineDetails("Calpol", 10, 5, new DateTime(2022, 05, 30));
        DataFiles.medicineList.Add(obj1);

        MedicineDetails obj2 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2022, 04, 30));
        DataFiles.medicineList.Add(obj2);

        MedicineDetails obj3 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2022, 10, 30));
        DataFiles.medicineList.Add(obj3);

        MedicineDetails obj4 = new MedicineDetails("Povidin Iodin", 10, 50, new DateTime(2022, 10, 30));
        DataFiles.medicineList.Add(obj4);

        //OrderDetail

        OrderDetails order = new OrderDetails("UID1001", "MD101", 3, 15, new DateTime(2022, 05, 13), o_status.Purchased);
        DataFiles.orderList.Add(order);

        OrderDetails order1 = new OrderDetails("UID1001", "MD102", 2, 10, new DateTime(2022, 05, 13), o_status.Cancelled);
        DataFiles.orderList.Add(order1);

        OrderDetails order2 = new OrderDetails("UID1001", "MD104", 2, 100, new DateTime(2022, 05, 13), o_status.Purchased);
        DataFiles.orderList.Add(order2);

        OrderDetails order3 = new OrderDetails("UID1002", "MD103", 3, 120, new DateTime(2022, 05, 15), o_status.Cancelled);
        DataFiles.orderList.Add(order3);

        OrderDetails order4 = new OrderDetails("UID1002", "MD105", 5, 250, new DateTime(2022, 05, 15), o_status.Purchased);
        DataFiles.orderList.Add(order4);

        OrderDetails order5 = new OrderDetails("UID1002", "MD102", 3, 15, new DateTime(2022, 05, 15), o_status.Purchased);
        DataFiles.orderList.Add(order5);


        
    }
}

