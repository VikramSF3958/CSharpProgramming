
namespace FoodDelivery
{
    public static class MainMenuClass
    {
        public static List<CustomerRegistration> customerList = new List<CustomerRegistration>();

        public static List<BookingDetails> bookingList = new List<BookingDetails>();

        public static List<FoodDetails> foodList = new List<FoodDetails>();

        public static void MainMenu()
        {   
            Console.Clear();
            string condition = "yes";
           
            while (condition == "yes")
            {   
                Console.ReadKey();
                System.Console.WriteLine();
                System.Console.WriteLine("          FOOD DELIVERY       ");
                System.Console.WriteLine();
                System.Console.WriteLine(" Main Menu ");
                System.Console.WriteLine();
                System.Console.WriteLine("1.Customer Registration \n2.Customer Login \n3.Exit");
                System.Console.Write("Enter the option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {   
                        //Customer Registration
                        Registration();
                        System.Console.WriteLine("Press any key to return to MainMenu...");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        //Customer Login
                        System.Console.WriteLine("Press any key to return to MainMenu...");
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {   
                        //Exit
                        condition = "no";
                        System.Console.WriteLine("Press any key to Exit...");
                        Console.ReadKey();
                        break;
                    }

                    default:
                    {   
                        System.Console.WriteLine("Entered an invalid option, try again!");
                        System.Console.WriteLine("Press any key to return to MainMenu...");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }

        public static void Registration()
        {
            Console.Clear();
            System.Console.WriteLine("          FOOD DELIVERY       ");
            System.Console.WriteLine();
            System.Console.WriteLine(" Registration Page ");
            System.Console.WriteLine();
            System.Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            
            System.Console.Write("Enter your Father nsme: ");
            string fname = Console.ReadLine();

            System.Console.Write("Enter your gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            System.Console.Write("Enter your mobile number: ");
            long mobile = long.Parse(Console.ReadLine());

            System.Console.Write("Your Date of Birth in (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            System.Console.Write("enter your mailid: ");
            string mailid = Console.ReadLine();
            
            System.Console.Write("Enter your location: ");
            string location = Console.ReadLine();
            
            System.Console.Write("Enter amount to recharge your wallet: ");
            double wallet = double.Parse(Console.ReadLine());

            CustomerRegistration obj = new CustomerRegistration(wallet, name, fname, gender, mobile, dob, mailid, location);
            
            customerList.Add(obj);

            System.Console.WriteLine($"Your customer ID: {obj.CustomerID}");
        }

        public static void Login()
        {
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("          FOOD DELIVERY       ");
            System.Console.WriteLine();
            System.Console.WriteLine("  LOGIN PAGE  ");
            System.Console.WriteLine();
            System.Console.Write("Enter  your Customer ID: ");
            string customerid = Console.ReadLine();
            
            CustomerRegistration temp = null;
            bool check = false;
            foreach(CustomerRegistration obj in customerList)
            {
                if(obj.CustomerID == customerid)
                {
                    check = true;
                    temp = obj;
                    break;
                }
            }

            if(check)
            {   
                //calling submenu
                SubMenuClass.SubMenu(temp);
            }
            else
            {
                System.Console.WriteLine("ID is Not present ");
            }

        }

    }
}