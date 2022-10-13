
namespace GroceryShop
{   
    public enum e_BookingStatus {  Default, Initiated, Booked, Cancelled }
    public class BookingDetails
    {
        private static int _bookingid = 3000;

        public string BookingID { get; }

        public string CustomerID { get; set; }

        public double TotalPrice { get; set; }

        public DateTime DateOfBooking { get; set; }

        public e_BookingStatus BookingStatus { get; set; }


        public BookingDetails()
        {

        }

        public BookingDetails(string customerid, double totalPrice, DateTime dateOfBooking, e_BookingStatus bookingStatus)
        {
            _bookingid++;
            BookingID = "BID"+_bookingid;
            CustomerID = customerid;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }

        public BookingDetails(string data)
        {
            string[] values = data.Split(',');
            _bookingid = int.Parse(values[0].Remove(0,3));
            BookingID = values[0];
            CustomerID = values[1];
            TotalPrice = double.Parse(values[2]);
            DateOfBooking = DateTime.ParseExact(values[3], "dd/MM/yyyy", null);
            BookingStatus = Enum.Parse<e_BookingStatus>(values[4], true);

        }
        public void ShowBookingDetails()
        {
            System.Console.WriteLine("Booking Details");
            System.Console.WriteLine();
            System.Console.WriteLine($"BookingID: {BookingID}");
            System.Console.WriteLine($"CustomerID: {CustomerID}");
            System.Console.WriteLine($"TotalPrice: {TotalPrice}");
            System.Console.WriteLine($"DateOfBooking: {DateOfBooking.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"BookingStatus: {BookingStatus}");

        }
    }
}