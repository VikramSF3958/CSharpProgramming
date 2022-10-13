
namespace GroceryShop
{
    public static class FilesData
    {
        public static void Create()
        {
            if(!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            if(!File.Exists("Data/Customer.csv"))
            {
                File.Create("Data/Customer.csv");
            }

            if(!File.Exists("Data/Bookings.csv"))
            {
                File.Create("Data/Bookings.csv");
            }

            if(!File.Exists("Data/Orders.csv"))
            {
                File.Create("Data/Orders.csv");
            }

            if(!File.Exists("Data/Products.csv"))
            {
                File.Create("Data/Products.csv");
            }
        }
    
        public static void Write()
        {
            //Writing Booking Details to files
            List<BookingDetails> bookingList = Operations.bookingList;

            string[] bookingData = new string[bookingList.Count];

            for(int i=0; i<bookingList.Count; i++)
            {
                bookingData[i] = bookingList[i].BookingID+","+bookingList[i].CustomerID+","+bookingList[i].TotalPrice+","+bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+bookingList[i].BookingStatus;
            }

            File.WriteAllLines("Data/Bookings.csv", bookingData);


            //Writing Customer Registration Details to files

            List<CustomerRegistration> customerList = Operations.customerList;

            string[] customerData = new string[customerList.Count];

            for(int i=0; i<customerList.Count; i++)
            {
                customerData[i] = customerList[i].CustomerID+","+customerList[i].WalletBalance+","+customerList[i].Name+","+customerList[i].FatherName+","+customerList[i].Gender+","+customerList[i].MobileNumber+","+customerList[i].DOB.ToString("dd/MM/yyyy")+","+customerList[i].MailId;
            }

            File.WriteAllLines("Data/Customer.csv", customerData);

            //Writing Order Details to Files

            List<OrderDetails> orderList = Operations.globalorderList;

            string[] orderData = new string[orderList.Count];

            for(int i=0; i<orderList.Count; i++)
            {
                orderData[i] = orderList[i].OrderID+","+orderList[i].BookingID+","+orderList[i].ProductID+","+orderList[i].PurchaseQuantity+","+orderList[i].PriceOfOrder;
            }

            File.WriteAllLines("Data/Orders.csv", orderData);

            List<ProductDetails> productList = Operations.productList;

            string[] productData = new string[productList.Count];

            for(int i=0; i<productList.Count;i++)
            {
                productData[i] = productList[i].ProductID+","+productList[i].ProductName+","+productList[i].QuantityAvailable+","+productList[i].PricePerQuantity;
            }

            File.WriteAllLines("Data/Products.csv", productData);



        }

        public static void Read()
        {   
            //Read Booking Details from Files
            string[] bookings = File.ReadAllLines("Data/Bookings.csv");

            foreach(string data in bookings)
            {
                Operations.bookingList.Add(new BookingDetails(data));
            }

            //Read Customer Details from Files
            string[] customer = File.ReadAllLines("Data/Customer.csv");

            foreach(string data in customer)
            {
                Operations.customerList.Add(new CustomerRegistration(data));
            }

            //Read Orders Details  from Files

            string[] orders = File.ReadAllLines("Data/Orders.csv");

            foreach(string data in orders)
            {
                Operations.globalorderList.Add(new OrderDetails(data));
            }

            //Read Products Details from Files

            string[] products = File.ReadAllLines("Data/Products.csv");

            foreach(string data in products)
            {
                Operations.productList.Add(new ProductDetails(data));
            }
        }
    }
}