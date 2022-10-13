
namespace FoodDelivery
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

            if(!File.Exists("Data/Product.csv"))
            {
                File.Create("Data/Product.csv");
            }

            if(!File.Exists("Data/Booking.csv"))
            {
                File.Create("Data/Booking.csv");
            }
        } 

        public static void Write()
        {
           List<CustomerRegistration> customerList = MainMenuClass.customerList;
           List<BookingDetails> bookingList = MainMenuClass.bookingList;
           List<FoodDetails> foodList = MainMenuClass.foodList;


            //Writing customer details
           string[] customer = new string[customerList.Count];

           for(int i=0; i<customerList.Count;i++)
           {
            customer[i] = customerList[i].CustomerID+","+customerList[i].Balance+","+customerList[i].Name+","+customerList[i].FatherName+","+customerList[i].Sex+","+customerList[i].Mobile+","+customerList[i].DOB.ToString("dd/MM/yyyy")+","+customerList[i].MailID+","+customerList[i].Location;
           } 

           File.WriteAllLines("Data/Customer.csv", customer);

           //writing food details
           string[] food = new string[foodList.Count];

           for(int i = 0; i<foodList.Count; i++)
           {
            food[i] = foodList[i].FoodID+","+foodList[i].FoodName+","+foodList[i].PricePerQuantity;
           }

           File.WriteAllLines("Data/Product.csv", food);

           //Writing Booking Details
           string[] booking = new string[bookingList.Count];

           for(int i=0; i<bookingList.Count; i++)
           {
            booking[i] = bookingList[i].BookingID+","+bookingList[i].CustomerID+","+bookingList[i].TotalPrice+","+bookingList[i].DateofBooking.ToString("dd/MM/yyyy")+","+bookingList[i].Status;
           }

           File.WriteAllLines("Data/BookingDetails.csv", booking);
        }
    
        public static void Read()
        {
            //Reading Booking File
            string[] booking = File.ReadAllLines("Data/Booking.csv");

            foreach(string data in booking)
            {
                MainMenuClass.bookingList.Add(new BookingDetails(data));
            }

            //Reading Customer File
            string[] customer = File.ReadAllLines("Data/Customer.csv");

            foreach(string data in customer)
            {
                MainMenuClass.customerList.Add(new CustomerRegistration(data));
            }

            //Reading Food File
            string[] food = File.ReadAllLines("Data/Product.csv");

            foreach(string data in food)
            {
                MainMenuClass.foodList.Add(new FoodDetails(data));
            }



        }
    }
}