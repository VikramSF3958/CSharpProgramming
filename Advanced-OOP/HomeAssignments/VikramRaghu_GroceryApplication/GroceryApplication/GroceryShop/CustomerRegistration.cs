
namespace GroceryShop
{
    public class CustomerRegistration : PersonalDetails, IBalance
    {   
        private static int _customerid = 1000;

        public string CustomerID { get;  }

        public double  WalletBalance { get; set; }

        public CustomerRegistration()
        {

        }

        public CustomerRegistration(string name, string fathername, e_Gender gender, long mobileNumber, DateTime dob, string mailId) : base (name, fathername, gender, mobileNumber, dob, mailId)
        {   
            _customerid++;
            CustomerID = "CID"+_customerid;

        }

        public CustomerRegistration(string data)
        {
            string[] values = data.Split(',');

            _customerid = int.Parse(values[0].Remove(0,3));
            CustomerID = values[0];
            WalletBalance = double.Parse(values[1]);
            Name = values[2];
            FatherName = values[3];
            Gender = Enum.Parse<e_Gender>(values[4], true);
            MobileNumber = long.Parse(values[5]);
            DOB = DateTime.ParseExact(values[6], "dd/MM/yyyy", null);
            MailId = values[7];
        }

        public void WalletRecharge()
        {
            System.Console.Write("Enter the amount to Recharge: ");
            WalletBalance += double.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine($"Your Wallet Balance is ${WalletBalance}");
        }

        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("Customer Details: ");
            System.Console.WriteLine();
            System.Console.WriteLine($"CustomerID: {CustomerID}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"FatherName: {FatherName}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"MobileNumber: {MobileNumber}");
            System.Console.WriteLine($"DOB: {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"MailID: {MailId}");
            System.Console.WriteLine($"Wallet Balance: {WalletBalance}");
        }


    }
}