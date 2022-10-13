
namespace Ecommerce
{
    public static class MainMenu
    {   
        //Lists
        public static List<CustomerDetails> customerDetailsList = new List<CustomerDetails>();
        public static List<OrderDetails> orderDetailsList = new List<OrderDetails>();
        public static List<ProductDetails> productDetailsList = new List<ProductDetails>();

        public static CustomerDetails User = null;
        public static void Menu()
        {
            string choice = "yes";

            while(choice == "yes")
            {   
                Console.Clear();

                System.Console.WriteLine("<-------- SYNCFUSION SHOP-STOP ----------->");
                System.Console.WriteLine();
                System.Console.WriteLine("1.Customer Registration\n2.Login and Purchase\n3.Exit");
                System.Console.WriteLine("Enter the Option: ");
                int Option = Convert.ToInt32(Console.ReadLine());

                switch(Option)
                {
                    case 1:
                    {   
                        //Customer Registartion
                        CreateCustomer();
                        break;
                    }

                    case 2:
                    {   
                        //Login and Purchase
                        Login();
                        break;
                    }

                    case 3:
                    {   
                        //Exit
                        System.Console.WriteLine("Exiting MainMenu...");
                        choice = "no";
                        break;
                    }
                }
            }
        }

        public static void CreateCustomer()
        {   
            System.Console.WriteLine("<-------- SYNCFUSION SHOP-STOP ----------->");
            System.Console.WriteLine();
            System.Console.WriteLine("Enter your Customer Name: ");
            string customerName = Console.ReadLine();
            
            System.Console.WriteLine("Enter your Customer City: ");
            string customerCity = Console.ReadLine();
            
            System.Console.WriteLine("Enter your Phone Number: ");
            long mobileNumber = Convert.ToInt64(Console.ReadLine());

            System.Console.WriteLine("Enter your MailID: ");
            string mailId = Console.ReadLine();
            
            System.Console.WriteLine("Enter your Wallet Initial Balance: ");
            double walletBalance = Convert.ToDouble(Console.ReadLine());

            CustomerDetails customer = new CustomerDetails(customerName, customerCity, mobileNumber, walletBalance, mailId);
            customerDetailsList.Add(customer);

            System.Console.WriteLine("Record Added Successfully");
            System.Console.WriteLine($"Your Customer ID: {customer.CustomerID}");

        }
    
        public static void Login()
        {
            System.Console.WriteLine("<-------- SYNCFUSION SHOP-STOP ----------->");
            System.Console.WriteLine();

            System.Console.WriteLine("Your Customer ID: ");
            string customerId = Console.ReadLine();
            int flag = 0;

            foreach(CustomerDetails tempObj in customerDetailsList)
            {   
                
                if(tempObj.CustomerID == customerId)
                {
                    User = tempObj;
                    SubMenu.LoginSubMenu(User);
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                System.Console.WriteLine("Oops!, You've Entered wrong ID");
            }
        }
                    
        
    }
}