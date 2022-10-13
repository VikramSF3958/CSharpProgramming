
namespace OnlineMedicalStore
{
    public static class MainMenu
    {
        public static void MainMenuMethod()
        {
            string condition = "yes";

            while (condition == "yes")
            {   
                Console.Clear();
                System.Console.WriteLine("       MEDICAL SHOP        ");
                System.Console.WriteLine();
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine("1.User Registration \n2.User Login \n3.Order History \n4.Exit");
                System.Console.Write("Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {   
                        //User Registration
                        UserRegistration();
                        System.Console.WriteLine("Press Any key to return to Main Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        //User Login
                        Login();
                        break;
                    }

                    case 3:
                    {   
                        //Order History
                        OrderHistory();
                        System.Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {   
                        //Exit
                        System.Console.WriteLine("Exiting from Main Menu...");
                        System.Console.WriteLine("Press Any key to Exit");
                        Console.ReadKey();
                        condition = "no";
                        break;
                    }

                    default:
                    {   
                        System.Console.WriteLine("You've entered an invalid Option !!");
                        System.Console.WriteLine("Press Any key to Enter again ");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }

        public static void UserRegistration()
        {
            Console.Clear();
            System.Console.WriteLine("       MEDICAL SHOP        ");
            System.Console.WriteLine();
            System.Console.WriteLine("Registration Page");
            System.Console.WriteLine();
            System.Console.Write("Enter a Username: ");
            string userName = Console.ReadLine();

            System.Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter your City: ");
            string city = Console.ReadLine();
            
            System.Console.Write("Enter your PhoneNumber: ");
            long phone = long.Parse(Console.ReadLine());

            System.Console.Write("Recharge your wallet: ");
            double balance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, age, city, phone, balance);

            DataFiles.userList.Add(user);

            System.Console.WriteLine($"User Account is created successfully\nYour ID: {user.UserID}");
        }
    
        public static void Login()
        {
            Console.Clear();
            System.Console.WriteLine("       MEDICAL SHOP        ");
            System.Console.WriteLine();
            System.Console.WriteLine(" LOGIN PAGE ");
            System.Console.WriteLine();

            System.Console.Write("User ID: ");
            string userid = Console.ReadLine();
            
            foreach(UserDetails obj in DataFiles.userList)
            {
                if(obj.UserID == userid)
                {
                    System.Console.WriteLine("Login Successfull !!");
                    LoginMenu.SubMenu(obj);
                }
                else
                {
                    System.Console.WriteLine("Sorry!, Couldn't find your record \n Please, Try Again");
                }
            }
        }

        public static void OrderHistory()
        {
            Console.Clear();
            System.Console.WriteLine("       MEDICAL SHOP        ");
            System.Console.WriteLine();
            System.Console.WriteLine(" Order History");
            System.Console.WriteLine();

            System.Console.WriteLine("ORDER ID     USERID          MEDICINEID          MEDICINE COUNT        TOTAL PRICE       ORDER DATE          ORDER STATUS ");
            foreach(OrderDetails tempOrder in DataFiles.orderList)
            {   
                
                System.Console.WriteLine($"{tempOrder.OrderId}      {tempOrder.UserId}              {tempOrder.MedicineId}                  {tempOrder.MedicineCount}                 {tempOrder.TotalPrice}           {tempOrder.OrderDate.ToString("dd/MM/yyyy")}            {tempOrder.Status}");

                
            }
        }
    
    }
}