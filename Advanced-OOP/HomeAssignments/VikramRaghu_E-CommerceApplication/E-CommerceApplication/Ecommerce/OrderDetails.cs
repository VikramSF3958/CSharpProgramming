
namespace Ecommerce;

public enum e_OrderStatus { Default, Ordered, Canceled }
    public class OrderDetails
    {
        static private int orderID = 1000;

        public string OrderId { get; set; }

        public string CustomerID { get; set; }

        public string ProductID { get; set; }

        public double TotalPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public e_OrderStatus OrderStatus { get; set; }

        public OrderDetails(String customerID, String productID, double totalPrice, DateTime purchaseDate, int quantity, e_OrderStatus orderStatus)
        {   
            orderID++;
            OrderId = "OID"+orderID;
            CustomerID = customerID;
            ProductID = productID;
            TotalPrice = totalPrice;
            PurchaseDate = purchaseDate;
            Quantity = quantity;
            OrderStatus = orderStatus;
        }

        public OrderDetails()
        {

        }

        public OrderDetails(string data)
        {
            string[] values = data.Split(',');
            OrderId = values[0];
            CustomerID = values[1];
            ProductID = values[2];
            TotalPrice = double.Parse(values[3]);
            PurchaseDate = DateTime.ParseExact(values[4], "dd/MM/yyyy", null);
            Quantity = int.Parse(values[5]);
            OrderStatus = Enum.Parse<e_OrderStatus>(values[6], true);
        }



    }
