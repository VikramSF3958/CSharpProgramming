
namespace FoodDelivery
{
    public static class SubMenuClass
    {
        public static void SubMenu(CustomerRegistration currentUser)
        {
            string condition = "yes";

            while(condition == "yes")
            {
                Console.ReadKey();
                System.Console.WriteLine($"Welcome, {currentUser.Name}");
                System.Console.WriteLine();
                System.Console.WriteLine(" Sub Menu ");
                System.Console.WriteLine();

                System.Console.WriteLine("1.Show Food Item Details \n2.Order Food \n3.Cancel Booking \n4.Order History \n5.Recharge Wallet \n6.Exit");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {   
                        //Show Food Item Details
                        ShowFoodItemDetails();
                        System.Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        //Order Food
                        OrderFood(currentUser);
                        System.Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {   
                        //Cancel Booking
                        CancelBooking(currentUser);
                        System.Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {   
                        //Order History
                        OrderHistory(currentUser);
                        System.Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        break;
                    }

                    case 5:
                    {   
                        //Recharge Wallet
                        Recharge(currentUser);
                        System.Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        break;
                    }

                    case 6:
                    {   
                        //Exit
                        System.Console.WriteLine("Exiting the Sub Menu...");
                        System.Console.WriteLine("Press any key to Exit to SubMenu...");
                        condition = "no";
                        Console.ReadKey();
                        break;
                    }

                    default:
                    {   
                        System.Console.WriteLine("Invalid option entered");
                        System.Console.WriteLine("Press any key to return to SubMenu...");
                        Console.ReadKey();
                        break;
                    }
                }

            }
        }

        public static void ShowFoodItemDetails()
        {
            Console.Clear();
            System.Console.WriteLine("          FOOD DELIVERY       ");
            System.Console.WriteLine();
            System.Console.WriteLine("Food ID          Food Name        Price per Quantity");
            foreach(FoodDetails temp in MainMenuClass.foodList)
            {
                System.Console.WriteLine($"{temp.FoodID}        {temp.FoodName}         {temp.PricePerQuantity}");
            }
        }
    
        public static void OrderFood(CustomerRegistration currentUser)
        {   
            Console.Clear();
            System.Console.WriteLine("          FOOD DELIVERY       ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.Name}");
            System.Console.WriteLine();
            System.Console.Write("Do you want to purchase: (yes/no)");
            string choice = Console.ReadLine().ToLower();
            double currentPrice = 0 ;

            BookingDetails bookObj = null;
            OrderDetails orderObj = new OrderDetails();

            while (choice == "yes")
            {
                bookObj = new BookingDetails(currentUser.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
                System.Console.WriteLine();
                //Calling Food Item Details
                ShowFoodItemDetails();

                System.Console.WriteLine();
                System.Console.Write("Select Food Item by Food ID: ");
                string foodid = Console.ReadLine();

                System.Console.Write("Enter your Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                FoodDetails foodObj = null;
                bool check = false;

                foreach(FoodDetails temp in MainMenuClass.foodList)
                {
                    if(temp.FoodID == foodid)
                    {
                        check = true;
                        foodObj = temp;
                        break;
                    }
                }

                if(check)
                {
                    //Calculating Price of orders
                    currentPrice  = (foodObj.PricePerQuantity * quantity);

                    if(currentPrice <= currentUser.Balance)
                    {
                        OrderDetails orderTemp = new OrderDetails(bookObj.BookingID, foodid, quantity, currentPrice);

                        //Adding to OrderList
                        orderObj.orderList.Add(orderTemp);
                        //OrderDetails.orderList.Add(orderTemp);

                        currentUser.Balance -= currentPrice;
                    }
                    else
                    {
                        System.Console.WriteLine("Balance not enough");
                    }

                   
                }
                else
                {
                    System.Console.WriteLine("The Selected Food ID is not Available");
                }

                System.Console.Write("want to add more to the cart: ");
                choice = Console.ReadLine().ToLower();

            }
            
            double totalcost = 0;
            foreach(OrderDetails temp in orderObj.orderList)
            {
                totalcost += temp.PriceOfOrder;
            }

            bookObj.CustomerID = currentUser.CustomerID;
            bookObj.TotalPrice = totalcost;
            bookObj.DateofBooking = DateTime.Now;
            bookObj.Status = BookingStatus.Booked;

            //Adding to booking list
            MainMenuClass.bookingList.Add(bookObj);

            System.Console.WriteLine();
            System.Console.WriteLine($"Booking successfull and Booking ID {bookObj.BookingID}");
        }
    
        public static void CancelBooking(CustomerRegistration currentUser)
        {
            Console.Clear();
            System.Console.WriteLine("          FOOD DELIVERY       ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.Name}");
            System.Console.WriteLine();
            System.Console.WriteLine(" Booking List ");
            System.Console.WriteLine();

            foreach(BookingDetails bookObj in MainMenuClass.bookingList)
            {
                if(bookObj.CustomerID == currentUser.CustomerID)
                {
                    System.Console.WriteLine($"{bookObj.BookingID}      {bookObj.TotalPrice}        {bookObj.TotalPrice}        {bookObj.DateofBooking.ToString("dd/MM/yyyy")}          {bookObj.Status}");
                }
            }
            System.Console.WriteLine();
            System.Console.Write("Enter the Booking Id you wish to cancel: ");
            string bookingid = Console.ReadLine();
            
            bool check = false;

            BookingDetails obj = null;

            foreach(BookingDetails bookObj in MainMenuClass.bookingList)
            {
                if(bookObj.BookingID == bookingid)
                {
                    obj = bookObj;
                    check = true;
                    break;
                }
            }
            if(check)
            {
                if(obj.Status == BookingStatus.Booked)
                {
                    obj.Status = BookingStatus.Cancelled;
                    currentUser.Balance += obj.TotalPrice;

                }
            }
            else
            {
                System.Console.WriteLine("Entered ID is not present");
            }

        }
    
        public static void OrderHistory(CustomerRegistration currentUser)
        {
            Console.Clear();
            System.Console.WriteLine("          FOOD DELIVERY       ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.Name}");
            System.Console.WriteLine();
            System.Console.WriteLine(" Order History ");
            System.Console.WriteLine();

            foreach(BookingDetails temp in MainMenuClass.bookingList)
            {
                if(temp.CustomerID == currentUser.CustomerID)
                {
                    System.Console.WriteLine($"{temp.BookingID}     {temp.CustomerID}       {temp.TotalPrice}       {temp.DateofBooking.ToString("dd/MM/yyyy")}         {temp.Status}");
                }
            }
        }
    
        public static void Recharge(CustomerRegistration currentUser)
        {   
            Console.Clear();
            System.Console.WriteLine("          FOOD DELIVERY       ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Welcome, {currentUser.Name}");
            System.Console.WriteLine();
            System.Console.WriteLine(" Recharge your wallet");
            System.Console.Write("Amount: ");
            currentUser.Balance += double.Parse(Console.ReadLine());
        }
    }
}