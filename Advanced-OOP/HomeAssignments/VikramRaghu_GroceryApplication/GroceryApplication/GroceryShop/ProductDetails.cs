
namespace GroceryShop
{
    public class ProductDetails
    {
        private static int _productid = 100;

        public string ProductID { get;  }

        public string ProductName { get; set; }

        public int QuantityAvailable { get; set; }

        public double PricePerQuantity { get; set; }

        public ProductDetails()
        {

        }

        public ProductDetails(string data)
        {
            string[] values = data.Split(',');

            _productid = int.Parse(values[0].Remove(0,3));
            ProductID = values[0];
            ProductName = values[1];
            QuantityAvailable = int.Parse(values[2]);
            PricePerQuantity = double.Parse(values[3]);
        }

        public ProductDetails(string productName, int quantityAvailable, double pricePerQuantity)
        {
            _productid++;
            ProductID = "PID"+_productid;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }

        public void ShowProductDetails()
        {
            System.Console.WriteLine("Product Details");
            System.Console.WriteLine();
            System.Console.WriteLine($"ProductID: {ProductID}");
            System.Console.WriteLine($"Product Name: {ProductName}");
            System.Console.WriteLine($"QuantityAvailable: {QuantityAvailable}");
            System.Console.WriteLine($"PricePerQuantity: {PricePerQuantity}");
        }
    }
}