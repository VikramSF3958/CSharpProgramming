
namespace GroceryShop
{
    public class OrderDetails
    {
        private static int _orderid = 100;

        public string OrderID { get;  }

        public string BookingID { get; set; }

        public string ProductID { get; set; }

        public int PurchaseQuantity { get; set; }

        public double PriceOfOrder { get; set; }

        public OrderDetails()
        {

        }

        public OrderDetails(string bookingid, string productid, int purchaseQuantity, double priceOfOrder)
        {
            _orderid++;
            OrderID = "OID"+_orderid;
            BookingID = bookingid;
            ProductID = productid;
            PurchaseQuantity = purchaseQuantity;
            PriceOfOrder = priceOfOrder;
        }

        public OrderDetails(string data)
        {
            string[] values = data.Split(',');
            _orderid = int.Parse(values[0].Remove(0,3));
            OrderID = values[0];
            BookingID = values[1];
            ProductID = values[2];
            PurchaseQuantity = int.Parse(values[3]);
            PriceOfOrder = double.Parse(values[4]);
        }

        public void ShowOrderDetails()
        {
            System.Console.WriteLine("Order Details");
            System.Console.WriteLine();
            System.Console.WriteLine($"OrderID: {OrderID}");
            System.Console.WriteLine($"BookingID: {BookingID}");
            System.Console.WriteLine($"ProductID: {ProductID}");
            System.Console.WriteLine($"PurchaseQuantity: {PurchaseQuantity}");
            System.Console.WriteLine($"PriceOfOrder: {PriceOfOrder}");

        }
    }
}