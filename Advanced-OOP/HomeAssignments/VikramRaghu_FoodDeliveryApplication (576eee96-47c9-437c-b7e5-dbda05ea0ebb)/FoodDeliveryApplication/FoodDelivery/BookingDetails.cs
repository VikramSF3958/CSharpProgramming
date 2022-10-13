
namespace FoodDelivery
{   
    public enum BookingStatus  { Default, Initiated, Booked, Cancelled }
    public class BookingDetails
    {   
       private static int _bookingid = 3000;

       public string BookingID { get; set; } 

       public string CustomerID { get; set; }

       public double TotalPrice { get; set; }

       public DateTime DateofBooking { get; set; }

       public BookingStatus Status { get; set; }

       public BookingDetails()
       {

       }

       public BookingDetails(string data)
       {
        string[] value = data.Split(',');
        _bookingid = int.Parse(value[0].Remove(0,3));
        BookingID = value[0];
        CustomerID = value[1];
        TotalPrice = double.Parse(value[2]);
        DateofBooking = DateTime.ParseExact(value[3], "dd/MM/yyyy", null);
        Status = Enum.Parse<BookingStatus>(value[4], true);
       }

       public BookingDetails(string customerid, double totalprice, DateTime dateofbooking, BookingStatus status)
       {
        _bookingid++;
        BookingID = "BID"+_bookingid;
        CustomerID = customerid;
        TotalPrice = totalprice;
        DateofBooking = dateofbooking;
        Status = status;
       }

        public void ShowBookingDetails(CustomerRegistration currentUser)
        {
            System.Console.WriteLine(" Booking Details ");
            System.Console.WriteLine();
            System.Console.WriteLine("Booking ID        Customer ID     TotalPrice      DateOfBooking       Booking Status");
            foreach(BookingDetails temp in MainMenuClass.bookingList)
            {
                if(temp.CustomerID == currentUser.CustomerID)
                {
                    System.Console.WriteLine($"{temp.BookingID}     {temp.CustomerID}       {temp.TotalPrice}       {temp.DateofBooking.ToString("dd/MM/yyyy")}        {temp.Status}");
                }
            }

        }
    }
}