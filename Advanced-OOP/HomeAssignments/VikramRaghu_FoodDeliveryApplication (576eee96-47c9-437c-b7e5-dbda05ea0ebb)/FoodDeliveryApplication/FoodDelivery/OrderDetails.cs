
namespace FoodDelivery
{
    public class OrderDetails
    {   
        public  List<OrderDetails> orderList = new List<OrderDetails>();
       private static int _orderid = 100;

       public string OrderID { get; set; } 

       public string  BookingID { get; set; }

       public string FoodID { get; set; }

       public int FoodCount { get; set; }

       public double PriceOfOrder { get; set; }

       public OrderDetails(string bookingid, string foodid, int foodcount, double priceoforder)
       {
        _orderid++;
        OrderID = "OID"+_orderid;
        BookingID = bookingid;
        FoodID = foodid;
        FoodCount = foodcount;
        PriceOfOrder = priceoforder;
       }

       public OrderDetails()
       {

       }
    
        public void ShowOrderDetails()
        {
            System.Console.WriteLine(" Order Details ");
            System.Console.WriteLine();
            System.Console.WriteLine("Order ID          Booking ID          Food ID         Purchase Count      Price of Order");
            foreach(OrderDetails temp in orderList)
            {
                System.Console.WriteLine($"{temp.OrderID}       {temp.BookingID}        {temp.FoodID}       {temp.FoodCount}        {temp.PriceOfOrder}");
            }
        }

    }
}