
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



    }
