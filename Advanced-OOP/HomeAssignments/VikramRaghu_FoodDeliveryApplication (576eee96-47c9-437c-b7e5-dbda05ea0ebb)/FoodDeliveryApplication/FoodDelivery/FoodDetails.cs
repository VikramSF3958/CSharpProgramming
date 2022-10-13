
namespace FoodDelivery
{
    public class FoodDetails
    {
        private static int _foodid = 100;
        public string FoodID { get; set; }

        public string FoodName { get; set; }

        public double PricePerQuantity { get; set; }

        public FoodDetails(string foodname, double price)
        {
            _foodid++;
            FoodID = "FID"+_foodid;
            FoodName = foodname;
            PricePerQuantity = price;
        }

        public FoodDetails(string data)
        {
            string[] values = data.Split(',');
            _foodid = int.Parse(values[0].Remove(0,3));
            FoodID = values[0];
            FoodName =values[1];
            PricePerQuantity = double.Parse(values[2]);
        }
    }
}