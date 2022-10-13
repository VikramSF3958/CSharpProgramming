
namespace OnlineMedicalStore
{
    public static class LoginMenu
    {
        public static void SubMenu(UserDetails currentUser)
        {
            string condition = "yes";

            while(condition == "yes")
            {
                Console.Clear();
                System.Console.WriteLine("       MEDICAL SHOP        ");
                System.Console.WriteLine();
                System.Console.WriteLine($"Welcome, {currentUser.UserName}");
                System.Console.WriteLine();

                System.Console.WriteLine("Sub Menu");
                System.Console.WriteLine("1.Show Medicine List\n2.Purchase Medicine\n3.Cancel Purchase\n4.Show Purchase History\n5.Recharge\n6.Exit");
                System.Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {   
                        //Show Medicine List
                        ShowMedicineList(currentUser);
                        System.Console.WriteLine("Press any key to return to Sub Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        //Purchase Medicine
                        PurchaseMedicine(currentUser);
                        System.Console.WriteLine("Press any key to return to Sub Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {   
                        //Cancel Purchase
                        CancelPurchase(currentUser);
                        System.Console.WriteLine("Press any key to return to Sub Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {   
                        //Show Purchase History
                        PurchaseHistory(currentUser);
                        System.Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }

                    case 5:
                    {   
                        //Recharge
                        Recharge(currentUser);
                        System.Console.WriteLine("Press any key to return to Sub Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 6: 
                    {   
                        //Exit
                        System.Console.WriteLine("Exiting Sub Menu...");
                        System.Console.WriteLine("Press any key to return to Main Menu...");
                        Console.ReadKey();
                        condition = "no";
                        break;
                    }

                    default:
                    {   
                        System.Console.WriteLine("You've entered an invalid option");
                        System.Console.WriteLine("Press any to key return to sub menu");
                        Console.ReadKey();
                        break;
                    }
                }


            }
        }

        public static void ShowMedicineList(UserDetails currentUser)
        {
            Console.Clear();
            System.Console.WriteLine("       MEDICAL SHOP        ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.UserName}");
            System.Console.WriteLine();

            System.Console.WriteLine(" Availabe Medicines ");
            System.Console.WriteLine("Medicine ID       Medicine Name           Available Count         Price           Date Of Expiry");
            foreach(MedicineDetails obj in DataFiles.medicineList)
            {
                System.Console.WriteLine($"{obj.MedicineId}             {obj.MedicineName}                  { obj.AvailableCount }                   { obj.Price }                 { obj.DateOfExpiry.ToString("dd/MM/yyyy") }       ");
            }
        }
    
        public static void Recharge(UserDetails currentUser)
        {
            Console.Clear();
            System.Console.WriteLine("       MEDICAL SHOP        ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.UserName}");
            System.Console.WriteLine();

            System.Console.WriteLine(" Your Wallet ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Available Balance: ${currentUser.Balance}");
            System.Console.WriteLine();
            System.Console.Write("Recharge your wallet by entering the amount: ");
            currentUser.Balance += double.Parse(Console.ReadLine());

            System.Console.WriteLine("Your Wallet has been Recharged SuccessFully");
            System.Console.WriteLine($"Available Balance: ${currentUser.Balance}");
        }
    
        public static void PurchaseMedicine(UserDetails currentUser)
        {   
            //Calling Show Medicine List to show available medicines
            ShowMedicineList(currentUser);

            System.Console.WriteLine();
            System.Console.Write("Enter the Medicine ID you wish to order: ");
            string medId = Console.ReadLine();

            System.Console.Write("Enter the Quantity: ");
            int medCount = int.Parse(Console.ReadLine());

            bool check = false;
            MedicineDetails medObj = null;

            foreach(MedicineDetails temp in DataFiles.medicineList)
            {
                if(temp.MedicineId == medId)
                {
                    check = true;
                    medObj = temp;
                    break;
                }
            }

            if(check)
            {
                if(medObj.AvailableCount >= medCount)
                {
                    if(medObj.DateOfExpiry >= DateTime.Now)
                    {
                        double totalCost =  medCount * medObj.Price;

                        if(currentUser.Balance >= totalCost)
                        {
                            OrderDetails orderObj = new OrderDetails(currentUser.UserID, medObj.MedicineId, medCount, totalCost, DateTime.Now, o_status.Purchased);
                            DataFiles.orderList.Add(orderObj);
                            
                            System.Console.WriteLine("Your order has been placed Successfully, \nThank You");

                            medObj.AvailableCount--;
                            currentUser.Balance -= totalCost;
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Sorry!, We dont have enough suppiles ");
                }
            }
            else
            {
                System.Console.WriteLine("Enter a valid medicine ID !!");
            }

        }
    
        public static void CancelPurchase(UserDetails currentUser)
        {
            Console.Clear();
            System.Console.WriteLine("       MEDICAL SHOP        ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.UserName}");
            System.Console.WriteLine();

            System.Console.WriteLine(" Your Order Details ");
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("OrderID       UserId      MedicineID      MedicineCount       TotalPrice      OrderDate           Status");
            foreach(OrderDetails temp in DataFiles.orderList)
            {
                if(temp.UserId == currentUser.UserID && temp.Status == o_status.Purchased)
                {
                    System.Console.WriteLine($"{temp.OrderId}       {temp.UserId}       {temp.MedicineId}               {temp.MedicineCount}                {temp.TotalPrice}            {temp.OrderDate.ToString("dd/MM/yyyy")}       {temp.Status}");
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Enter the OrderID of item you wish to cancel");
            string orderid = Console.ReadLine();
            
            bool check = false;
            OrderDetails tempOrder = null;
            foreach(OrderDetails temp in DataFiles.orderList)
            {
                if(temp.OrderId == orderid)
                {
                    check = true;
                    tempOrder = temp;
                    break;
                }
            }

            if(check)
            {
                if(tempOrder.Status == o_status.Purchased)
                {
                    foreach(MedicineDetails tempMed in DataFiles.medicineList)
                    {
                        if(tempMed.MedicineId == tempOrder.MedicineId)
                        {
                            tempMed.AvailableCount += tempOrder.MedicineCount;
                            currentUser.Balance += tempOrder.TotalPrice;
                            tempOrder.Status = o_status.Cancelled;
                            System.Console.WriteLine($"{tempOrder.OrderId} was cancelled successfully");
                            System.Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                    }

                }
            }
            else
            {
                System.Console.WriteLine("Entered Order ID is present. Returning to Sub Menu...");
                System.Console.WriteLine("Press Any key to continue...");
                Console.ReadKey();
            }
        }
    
        public static void PurchaseHistory(UserDetails currentUser)
        {
            Console.Clear();
            System.Console.WriteLine("       MEDICAL SHOP        ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.UserName}");
            System.Console.WriteLine();

            System.Console.WriteLine(" Your Purchase History ");
            System.Console.WriteLine();

            System.Console.WriteLine("ORDER ID     MEDICINEID          MEDICINE COUNT        TOTAL PRICE       ORDER DATE          ORDER STATUS ");
            foreach(OrderDetails tempOrder in DataFiles.orderList)
            {   
                if(tempOrder.UserId == currentUser.UserID && tempOrder.Status == o_status.Purchased)
                {
                    System.Console.WriteLine($"{tempOrder.OrderId}      {tempOrder.MedicineId}                  {tempOrder.MedicineCount}                 {tempOrder.TotalPrice}               {tempOrder.OrderDate.ToString("dd/MM/yyyy")}            {tempOrder.Status}");
                }
                
            }
        }
    }
}