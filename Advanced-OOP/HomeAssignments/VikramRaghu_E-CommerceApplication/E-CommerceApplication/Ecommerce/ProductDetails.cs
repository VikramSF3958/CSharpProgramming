
namespace Ecommerce;
    public class ProductDetails
    {
        static private int productID = 101;

        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public int ShippingDuration { get; set; }

        public ProductDetails()
        {

        }

        public ProductDetails(string productName, double price, int stock, int shippingDuration)
        {   
            ProductID = "PID"+productID;
            productID++;
            ProductName = productName;
            Price = price;
            Stock = stock;
            ShippingDuration = shippingDuration;

        }

        public ProductDetails(string data)
        {
            string[] values = data.Split(',');

            ProductID = values[0];
            ProductName = values[1];
            Price = double.Parse(values[2]);
            Stock = int.Parse(values[3]);
            ShippingDuration = int.Parse(values[4]);

        }

        
    }