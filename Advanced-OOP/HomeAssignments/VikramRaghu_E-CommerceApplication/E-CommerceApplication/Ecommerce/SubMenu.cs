
namespace Ecommerce
{
    //For showing SubMenu in Login
    public static class SubMenu
    {
        //SubMenu
        public static void LoginSubMenu(CustomerDetails currentUser)
        {

            string choice = "yes";

            while (choice == "yes")
            {
                Console.Clear();
                System.Console.WriteLine("<-------- SYNCFUSION SHOP-STOP ----------->");
                System.Console.WriteLine();
                System.Console.WriteLine("a.Purchase\nb.Order History\nc.Cancel Order\nd.Wallet Balance\ne.Exit");
                char Option = Convert.ToChar(Console.ReadLine());

                switch (Option)
                {
                    case 'a':
                        {
                            //Purchase
                            purchase(currentUser);
                            break;
                        }

                    case 'b':
                        {
                            //Order History
                            OrderHistory(currentUser);
                            System.Console.WriteLine("Press Any key to continue");
                            Console.ReadKey();
                            break;
                        }

                    case 'c':
                        {
                            //Cancel Order
                            CancelOrder(currentUser);
                            System.Console.WriteLine("Press Any key to continue");
                            Console.ReadKey();
                            break;
                        }

                    case 'd':
                        {
                            //Wallet Balance
                            System.Console.WriteLine($"Your Wallet Balance :{currentUser.WalletBalance}");
                            System.Console.WriteLine("Press Any key to return to Sub-Menu");
                            Console.ReadKey();
                            break;
                        }

                    case 'e':
                        {
                            //Exit
                            System.Console.WriteLine("Exiting SubMenu...");
                            choice = "no";
                            System.Console.WriteLine("Press Any key to return to Sub-Menu");
                            Console.ReadKey();
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine("You've entered wrong choice");
                            break;
                        }
                }
            }
        }

        public static void purchase(CustomerDetails currentUser)
        {
            //Calling ShowProducts methods to display Product List
            ShowProducts();

            System.Console.WriteLine();
            System.Console.WriteLine("Select by ProductID: ");
            string productId = Console.ReadLine();

            System.Console.WriteLine("Enter the Quantity you want to buy: ");
            int requiredQuantity = Convert.ToInt32(Console.ReadLine());

            ProductDetails productObj = null;
            foreach (ProductDetails tempObj in MainMenu.productDetailsList)
            {
                if (tempObj.ProductID == productId)
                {
                    productObj = tempObj;
                    break;
                }
            }

            if (productObj.Stock < requiredQuantity)
            {
                System.Console.WriteLine("Required Count is NOT AVAILABLE ");
                System.Console.WriteLine();
                System.Console.WriteLine($"Current Availablity: {productObj.Stock}");
            }
            else
            {
                double deliveryCharge = 50;
                double totalAmount = (requiredQuantity * productObj.Price) + deliveryCharge;

                if (currentUser.WalletBalance >= totalAmount)
                {
                    currentUser.WalletBalance -= totalAmount;
                    productObj.Stock -= requiredQuantity;
                    System.Console.WriteLine();

                    OrderDetails OrdertempObj = new OrderDetails(currentUser.CustomerID, productObj.ProductID, totalAmount, DateTime.Now, requiredQuantity, e_OrderStatus.Ordered);
                    MainMenu.orderDetailsList.Add(OrdertempObj);
                    System.Console.WriteLine("Order Confirmed");

                    System.Console.WriteLine($"Order placed successfully. Your order will be delivered on {OrdertempObj.PurchaseDate.AddDays(productObj.ShippingDuration)}");
                }
                else
                {
                    System.Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet");
                }
            }

            System.Console.WriteLine("Press Any key to return to SubMenu");
            Console.ReadKey();
        }

        public static void ShowProducts()
        {
            System.Console.WriteLine("Product Lists");
            System.Console.WriteLine("Product ID    Product Name      Available Stock     PricePerQuantity      Shipping Duration");
            foreach (ProductDetails tempObj in MainMenu.productDetailsList)
            {
                System.Console.WriteLine($"{tempObj.ProductID}          {tempObj.ProductName}               {tempObj.Stock}                     {tempObj.Price}                  {tempObj.ShippingDuration}");
                System.Console.WriteLine();
            }
        }

        public static void OrderHistory(CustomerDetails currentUser)
        {
            foreach (OrderDetails tempObject in MainMenu.orderDetailsList)
            {
                if (tempObject.CustomerID == currentUser.CustomerID)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Order ID: {tempObject.CustomerID}");
                    System.Console.WriteLine($"Customer ID: {tempObject.ProductID}");
                    System.Console.WriteLine($"Order ID: {tempObject.OrderId}");
                    System.Console.WriteLine($"Price: {tempObject.TotalPrice}");
                    System.Console.WriteLine($"Purchase Date: {tempObject.PurchaseDate}");
                    System.Console.WriteLine($"Quantity: {tempObject.Quantity}");
                    System.Console.WriteLine($"Order Status: {tempObject.OrderStatus}");
                }
            }
        }

        public static void CancelOrder(CustomerDetails currentUser)
        {
            OrderHistory(currentUser);

            System.Console.WriteLine();
            System.Console.Write("Enter the Order ID:");
            string orderId = Console.ReadLine();
            
            bool found = false;
            OrderDetails OrderObject = null;
            
            foreach(OrderDetails Ordertemp in MainMenu.orderDetailsList)
            {
                if(Ordertemp.OrderId == orderId)
                {
                    found = true;
                    OrderObject = Ordertemp;
                    break;
                }
            }

            if(found)
            {
                if(OrderObject.OrderStatus == e_OrderStatus.Ordered)
                {
                    foreach(ProductDetails productObj in MainMenu.productDetailsList)
                    {
                        if(productObj.ProductID == OrderObject.ProductID)
                        {
                            OrderObject.OrderStatus = e_OrderStatus.Canceled;
                            productObj.Stock += OrderObject.Quantity;

                            currentUser.WalletBalance += OrderObject.TotalPrice - 50;
                            System.Console.WriteLine("Order Cancelled and refunded successfully to your account");

                        }
                    }
                }
            }
        }
    }
}