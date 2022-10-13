
namespace Ecommerce
{
    public class CustomerDetails
    {
        static private int s_customerId = 1000;

        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string City { get; set; }

        public long  MobileNumber { get; set; }

        public double WalletBalance { get; set; }

        public string EmailID { get; set; }

        public CustomerDetails()
        {

        }

        public CustomerDetails(string customerName, string customerCity, long mobileNumber, double walletBalance, string EmailId)
        {   
            s_customerId++;
            CustomerID = "CID"+s_customerId;
            CustomerName = customerName;
            City = customerCity;
            MobileNumber = mobileNumber;
            WalletBalance = walletBalance;
            EmailID = EmailId;
        }

        public CustomerDetails(string data)
        {
            string[] values = data.Split(',');
            CustomerID = values[0];
            CustomerName = values[1];
            City = values[2];
            MobileNumber = long.Parse(values[3]);
            WalletBalance = double.Parse(values[4]);
            EmailID = values[5];
        }


    }
}