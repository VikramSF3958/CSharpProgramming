
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


    }
}