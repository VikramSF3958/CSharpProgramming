
namespace GroceryShop
{
    public static class Operations
    {   
        
    public static CustomerRegistration currentLoggedinCustomer = null;
    public static List<CustomerRegistration> customerList = new List<CustomerRegistration>();
    public static List<ProductDetails> productList = new List<ProductDetails>();
    public static List<BookingDetails> bookingList = new List<BookingDetails>();
    public static List<OrderDetails> globalorderList = new List<OrderDetails>();

    //Main Function
    public static void MainMethod()
    {   
        //Default Values 
        //Default();

        string condition = "yes";

        //Runnning the Main Menu in Loop
        do
        {   
           
            Console.Clear();
            System.Console.WriteLine("Main Menu");
            System.Console.WriteLine("1.Customer Registration \n2.Customer Login \n3.Exit");
            System.Console.Write("Enter the option: ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {   
                    //Calling Customer Registration Method
                    CustomerRegisrtationMethod();
                    Console.ReadKey();
                    break;
                }

                case 2:
                {   
                    //Calling Customer Login Method
                    CustomerLogin();
                    Console.ReadKey();
                    break;
                }

                case 3:
                {   
                    System.Console.WriteLine("You've chosen Exit");
                    condition = "no";
                    System.Console.WriteLine("Press Any key to Exit the Application...");
                    Console.ReadKey();
                    break;
                }

                default:
                {   
                    System.Console.WriteLine("Invalid Option Selected");
                    break;
                }
            }

        }while(condition!="no");

        
    }

    static void CustomerRegisrtationMethod()
    {   
        Console.Clear();
        System.Console.WriteLine();
        System.Console.WriteLine(" Customer Registration Page ");
        System.Console.WriteLine();
        System.Console.Write("Enter your Name: ");
        string name = Console.ReadLine();
        
        System.Console.Write("Enter your FatherName: ");
        string fatherName = Console.ReadLine();
        
        System.Console.Write("Enter your Gender: ");
        e_Gender gender = Enum.Parse<e_Gender>(Console.ReadLine(), true);

        System.Console.Write("Enter your Mobile Number: ");
        long mobileNumber = long.Parse(Console.ReadLine());

        System.Console.Write("Enter your Date of Birth in (dd/MM/yyyy): ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        System.Console.Write("Enter your Mail ID: ");
        string mailId = Console.ReadLine();

        //Creating an Customer Registration Object for the data
        CustomerRegistration customer = new CustomerRegistration(name, fatherName, gender, mobileNumber, dob, mailId);
        customerList.Add(customer); //Adding to the Customer List

        System.Console.WriteLine($"\nYour Details has been Added Succeddfully, \nYour Customer ID is {customer.CustomerID}");
    }

    static void CustomerLogin()
    {   
        Console.Clear();
        System.Console.WriteLine(" Customer Login Page ");
        System.Console.WriteLine();
        System.Console.Write("Enter your Customer ID: ");
        string customerid = Console.ReadLine().ToUpper();

        bool check = true;
        foreach(CustomerRegistration customer in customerList)
        {
            if(customer.CustomerID == customerid)
            {
                System.Console.WriteLine("Login SuccessFull");
                check = false;
                currentLoggedinCustomer = customer;

                //Calling SubMenu
                SubMenu();

                break;
            }
        }

        if(check)
        {
            System.Console.WriteLine("User doesn't Exists");
        }
        
    }

    static void SubMenu()
    {   string condition = "yes";
        do
        {   
            Console.Clear();
            System.Console.WriteLine($"Welcome, {currentLoggedinCustomer.Name}");
            System.Console.WriteLine();
            System.Console.WriteLine("Sub Menu");
            System.Console.WriteLine("1.Show Customer Details \n2.Show Product Details \n3.Wallet Recharge \n4.Take Order \n5.Modify Order Quantity \n6.Cancel Order \n7.Exit");
            System.Console.Write("Enter the option: ");
            int option = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            switch(option)
            {
                case 1:
                {   
                    //Calling Show Customer Details
                    currentLoggedinCustomer.ShowCustomerDetails();
                    Console.ReadKey();
                    break;
                }

                case 2:
                {   
                    //Calling Show Product Details
                    ShowProductDetails();
                    Console.ReadKey();
                    break;
                }

                case 3:
                {   
                    //Wallet Recharge
                    currentLoggedinCustomer.WalletRecharge();
                    Console.ReadKey();
                    break;
                }

                case 4:
                {   
                    //Take Order
                    TakeOrder();
                    Console.ReadKey();
                    break;
                }

                case 5:
                {   
                    //Modify Order
                    ModifyOrder();
                    Console.ReadKey();
                    break;
                }

                case 6:
                {      
                    //Cancel Order
                    CancelOrder();
                    System.Console.WriteLine("Cancel Order");
                    Console.ReadKey();
                    break;
                }
                case 7:
                {   
                    //Exit
                    System.Console.WriteLine("Exiting the SubMenu..Logging you Out");
                    condition = "no";
                    System.Console.WriteLine("Press Any key to continue...");
                    break;
                }

                default:
                {   
                    System.Console.WriteLine("Invalid Option");
                    break;
                }
            }
            
        }while(condition!="no");
    }

    static void ShowProductDetails()
    {
         //Displaying  Product
            System.Console.WriteLine(" <------------- PRODUCT DETAILS ------------>");
            System.Console.WriteLine();
            foreach(ProductDetails product in productList)
            {
                product.ShowProductDetails();
                System.Console.WriteLine();
            }
    }

    static void TakeOrder()
    {
        /* Create a Booking Object

            do-while:
                1. Show Product Details list
                2. Select a product & check wether it is present
                    2.1 if present, get the quantity and check for availablity
                    2.2 Take Order and create object and add in local list

        */

        //Creating a Booking Object
        double totalPrice = 0;
        BookingDetails bookingObject = new BookingDetails(currentLoggedinCustomer.CustomerID, totalPrice, DateTime.Now, e_BookingStatus.Initiated );
        List<OrderDetails> temporaryOrderList = new List<OrderDetails>();
        
        double TotalCostOfOrder = 0;

        string choice = "yes";

        do
        {
            //Calling Product Details List
            ShowProductDetails();

            //Asking customer to select a product using ProductID
            System.Console.Write("Select the product by entering the ProductID: ");
            string productid = Console.ReadLine().ToUpper();
            
            //Creating a temporary variable of type ProductDetails
            ProductDetails tempProduct = null;

            bool flag = false;
            foreach(ProductDetails product in productList)
            {
                if(product.ProductID == productid)
                {
                    tempProduct = product;
                    flag = true;
                    break;
                }
            }

            if(flag)
            {   
                //Asking customer to enter the quantity
                System.Console.Write("Enter the quantity you wish to buy: ");
                int quantity = int.Parse(Console.ReadLine());

                //Checking if the Asking Quantity is available in the selected product
                if(tempProduct.QuantityAvailable >= quantity)
                {
                    double totalPriceOfProduct = tempProduct.PricePerQuantity * quantity;
                    OrderDetails orderObject = new OrderDetails(bookingObject.BookingID, tempProduct.ProductID, quantity, totalPriceOfProduct);
                    temporaryOrderList.Add(orderObject);

                    System.Console.WriteLine($"Your Product '{tempProduct.ProductName}' with quantity '{quantity}' has been added to your cart successfully\nYour Order ID is '{orderObject.OrderID}' ");
                    
                    //Deducting the Product quantity after adding to the cart
                    tempProduct.QuantityAvailable -= quantity;
        
                }
                else
                {
                    System.Console.WriteLine("We don't have enough quantity");
                }
            }
            else
            {
                System.Console.WriteLine("Product is not available");
            }



            System.Console.Write("Do you want to add another product to your cart ? (yes/no)");
            choice = Console.ReadLine();

        }while(choice!="no");

        
        //Calculates total Order Price
        foreach(OrderDetails order in temporaryOrderList)
        {
            TotalCostOfOrder += order.PriceOfOrder;
        }

        //Asking customer wether he wishes to proceed with order
        System.Console.WriteLine("Do you want proceed with this order (yes/no):    ");
        string wish = Console.ReadLine().ToLower();


        if(wish == "yes")
        {   
            //If wishes to proceed with this orders
            while(true)
            {   
                // checking if customer has enough balance in his wallet, if not asking to recharge him
                if(TotalCostOfOrder <= currentLoggedinCustomer.WalletBalance)
                {
                    bookingObject.CustomerID = currentLoggedinCustomer.CustomerID;
                    bookingObject.TotalPrice = TotalCostOfOrder;
                    bookingObject.BookingStatus = e_BookingStatus.Booked;

                    //Adding to the Booking List
                    bookingList.Add(bookingObject);


                    System.Console.WriteLine($"Your Orders has been Booked Successfully\nYour BookingID is {bookingObject.BookingID}");
                    currentLoggedinCustomer.WalletBalance -= TotalCostOfOrder;

                    globalorderList.AddRange(temporaryOrderList);

                    break;
                }
                else
                {   
                    //Executes untill wallet has sufficient balance to place order
                    do
                    {   
                        System.Console.WriteLine("You're having insufficient balance");
                        System.Console.WriteLine($"You need more {TotalCostOfOrder - currentLoggedinCustomer.WalletBalance}");
                        System.Console.WriteLine("Recharge your wallet");
                        currentLoggedinCustomer.WalletRecharge();

                    }while(currentLoggedinCustomer.WalletBalance <= TotalCostOfOrder);

                }
            }
        }
        else if(wish == "no")
        {
            foreach(OrderDetails order in globalorderList)
            {   
                foreach(ProductDetails product in productList)
                {
                    if(order.ProductID == product.ProductID)
                    {
                        product.QuantityAvailable += order.PurchaseQuantity;
                    }
                }
                
            }
        }

        
    
    }

    static void ModifyOrder()
    {   
        Console.Clear();
        System.Console.WriteLine(" Modify Your Order ");
        System.Console.WriteLine();

        System.Console.WriteLine("BookingID         Booking Total Price     Booking Date        Booking Status  ");
        foreach(BookingDetails booking in bookingList)
        {
            if(booking.CustomerID == currentLoggedinCustomer.CustomerID)
            {
                System.Console.WriteLine($"{booking.BookingID}                       {booking.TotalPrice}           {booking.DateOfBooking.ToString("dd/MM/yyyy")}      {booking.BookingStatus}");
            }
        }

        System.Console.WriteLine();
        System.Console.Write("Select by Booking ID to modify with Status 'Booked' : ");
        string bookingId = Console.ReadLine();

        BookingDetails tempBookingObject = null;
        bool flag = false;
        foreach(BookingDetails booking in bookingList)
        {
            if(booking.BookingID == bookingId && booking.BookingStatus == e_BookingStatus.Booked)
            {
                flag = true;
                tempBookingObject = booking;
                break;
            }
        }
        if(flag)
        {   
            System.Console.WriteLine();
            System.Console.WriteLine("OrderID         BookingID         ProductID       PurchaseQuantity        PriceOfOrder");
            foreach(OrderDetails order in globalorderList)
            {
                System.Console.WriteLine($"{order.OrderID}          {order.BookingID}           {order.ProductID}                   {order.PurchaseQuantity}                    {order.PriceOfOrder}");
            }
            System.Console.WriteLine();
            System.Console.Write("Select by entering the OrderID: ");
            string orderid = Console.ReadLine();
            

            OrderDetails tempOrderObject = null;
            bool check = false;

            foreach(OrderDetails order in globalorderList)
            {
                if(order.OrderID == orderid)
                {   
                    tempOrderObject = order;
                    check = true;
                    break;
                }
            }

            if(check)
            {      
                //Showing Product Details
                ShowProductDetails();
                System.Console.WriteLine();

                //Updating the quantity
                System.Console.Write("Do you want to \n1.increase  \n2.decrease the Quantity (1/2): ");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {   
                    System.Console.WriteLine($"Enter the Quantity of Product with ID {tempOrderObject.ProductID}");
                    int quantity = int.Parse(Console.ReadLine());
                    
                   foreach(ProductDetails product in productList)
                    {
                        if(product.ProductID == tempOrderObject.ProductID)
                        {
                            if(quantity <= product.QuantityAvailable)
                            {
                                tempOrderObject.PurchaseQuantity += quantity;
                                product.QuantityAvailable -= quantity;

                                double totalPrice = product.PricePerQuantity * quantity;

                               while(true)
                               {

                                    if(totalPrice > currentLoggedinCustomer.WalletBalance)
                                    {   
                                        do
                                        {   
                                            System.Console.WriteLine("You don't have enough balance");

                                            System.Console.WriteLine();
                                            System.Console.WriteLine("Recharge your wallet");
                                            currentLoggedinCustomer.WalletRecharge();

                                        }while(totalPrice >= currentLoggedinCustomer.WalletBalance);
                                        

                                    }
                                    else
                                    {
                                        tempOrderObject.PriceOfOrder += totalPrice;

                                        product.QuantityAvailable -= quantity;

                                        System.Console.WriteLine("Your Order has been updated");
                                        break;
                                    }
                               }
                            }
                            else
                            {
                                System.Console.WriteLine("Not enough Quantity");
                            }
                        }
                    }  

                }else if(choice == 2)
                {   
                    System.Console.WriteLine($"Enter the Quantity of Product with ID {tempOrderObject.ProductID}");
                    int quantity = int.Parse(Console.ReadLine());
                     
                   foreach(ProductDetails product in productList)
                    {
                        if(product.ProductID == tempOrderObject.ProductID)
                        {
                            product.QuantityAvailable += quantity;
                            tempOrderObject.PurchaseQuantity -= quantity;
                            double totalPrice = quantity * product.PricePerQuantity;
                            tempOrderObject.PriceOfOrder -= totalPrice;
                            currentLoggedinCustomer.WalletBalance += totalPrice;

                            System.Console.WriteLine("Your order has been updated");
                        }
                    }  
                }

               
            }
            else
            {
                System.Console.WriteLine("Selected Order ID is not present ");
            }
        }
        else
        {
            System.Console.WriteLine("Selected booking ID is not present !!!");
        }
        
    }
    
    static void CancelOrder()
    {   
        System.Console.WriteLine();
        System.Console.WriteLine(" Cancel Booking ");
        System.Console.WriteLine();

        bool check = false;
        BookingDetails bookObject = null;

        System.Console.WriteLine("BookingID             CustomerID              TotalPrice              DateOfBooking           BookingStatus");
        foreach(BookingDetails booking in bookingList)
        {
            System.Console.WriteLine($"{booking.BookingID}          {booking.CustomerID}            {booking.TotalPrice}            {booking.DateOfBooking.ToString("dd/MM/yyyy")}          {booking.BookingStatus}");
        }

        foreach(BookingDetails booking in bookingList)
        {
            if(booking.CustomerID == currentLoggedinCustomer.CustomerID && booking.BookingStatus == e_BookingStatus.Booked)
            {
                check = true;
                bookObject = booking;
                break;
            }
        }

        if(check)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Select the Booking ID: ");
            string bookingId = Console.ReadLine();

            if(bookObject.BookingID == bookingId)
            {
                bookObject.BookingStatus = e_BookingStatus.Cancelled;
                System.Console.WriteLine("Booking has been cancelled successfully");
                currentLoggedinCustomer.WalletBalance += bookObject.TotalPrice;
            }
            else
            {
                System.Console.WriteLine("Entered booking ID is not present ");
            }
        }
        else
        {
            System.Console.WriteLine("No bookings available ");
        }
    }
    
    static void Default()
    {
        //CUSTOMER RERGISTRATION
            CustomerRegistration cus1 = new CustomerRegistration("Ravi", "Ettapparajan", e_Gender.Male, 974774646, new DateTime(1999, 11, 11), "ravi@gmail.com");
            customerList.Add(cus1);

            CustomerRegistration cus2 = new CustomerRegistration("Baskaran", "Sethurajan", e_Gender.Male, 847575775,  new DateTime(1999, 11, 11), "baskaran@gmail.com");
            customerList.Add(cus2);


            //PRODUCT REGISTRATION
            ProductDetails prdt1 = new ProductDetails("Sugar", 20, 40);
            productList.Add(prdt1);

            ProductDetails prdt2 = new ProductDetails("Rice",100,50);
            productList.Add(prdt2);

            ProductDetails prdt3 = new ProductDetails("Milk",10,40);
            productList.Add(prdt3);

            ProductDetails prdt4 = new ProductDetails("Coffee",10,10);
            productList.Add(prdt4);

            ProductDetails prdt5 = new ProductDetails("Tea",10,10);
            productList.Add(prdt5);

            ProductDetails prdt6 = new ProductDetails("Masala Powder",10,20);
            productList.Add(prdt6);

            ProductDetails prdt7 = new ProductDetails("Salt",10,10);
            productList.Add(prdt7); 

            ProductDetails prdt8 = new ProductDetails("Turmeric Powder",10,25);
            productList.Add(prdt8);

            ProductDetails prdt9 = new ProductDetails("Chilli Powder",10,20);
            productList.Add(prdt9); 

            ProductDetails prdt10 = new ProductDetails("Groundnut Oil",10,140);
            productList.Add(prdt10); 



            //BOOKING DETAILS
            BookingDetails book1 = new BookingDetails("CID3001", 220, new DateTime(2022, 07, 26), e_BookingStatus.Booked);
            bookingList.Add(book1);

            BookingDetails book2 = new BookingDetails("CID3002",400, new DateTime(2022, 07, 26),e_BookingStatus.Booked);
            bookingList.Add(book2);

            BookingDetails book3= new BookingDetails("CID3002",280, new DateTime(2022, 07, 26),e_BookingStatus.Cancelled);
            bookingList.Add(book3);

            BookingDetails book4 = new BookingDetails("CID3002",0,new DateTime(2022,07,26),e_BookingStatus.Initiated);
            bookingList.Add(book4);




            //ORDER DETAILS
            OrderDetails order1 = new OrderDetails("BID3001", "PID101", 2, 80);
            globalorderList.Add(order1);

            OrderDetails order2 = new OrderDetails("BID3001","PID102",2,100);
            globalorderList.Add(order2);

            OrderDetails order3 = new OrderDetails("BID3001","PID103",1,40);
            globalorderList.Add(order3); 

            OrderDetails order4 = new OrderDetails("BID3002","PID101",1,40);
            globalorderList.Add(order4);

            OrderDetails order5 = new OrderDetails("BID3002","PID102",4,200);
            globalorderList.Add(order5); 

            OrderDetails order6 = new OrderDetails("BID3002","PID110",1,140);
            globalorderList.Add(order6); 

            OrderDetails order7 = new OrderDetails("BID3002","PID109",1,20);
            globalorderList.Add(order7); 

            OrderDetails order8 = new OrderDetails("BID3003","PID102",2,100);
            globalorderList.Add(order8);

            OrderDetails order9 = new OrderDetails("BID3003","PID108",4,100);
            globalorderList.Add(order9); 

            OrderDetails order10 = new OrderDetails("BID3003","PID101",2,80);
            globalorderList.Add(order10); 
    }

    }

    
}