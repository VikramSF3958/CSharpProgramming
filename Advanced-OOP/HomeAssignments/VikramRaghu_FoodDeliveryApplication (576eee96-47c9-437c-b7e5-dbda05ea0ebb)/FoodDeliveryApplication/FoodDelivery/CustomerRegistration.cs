
namespace FoodDelivery
{
    public class CustomerRegistration : PersonalDetails, IBalance
    {   
        private static int _customerid = 1000;

        public string CustomerID { get; set; }

        public double Balance { get; set; }


        public CustomerRegistration(double balance , string name, string fathername, Gender sex, long mobile, DateTime dob, string mailid, string location) : base (name, fathername, sex, mobile, dob, mailid, location)
        {   
            _customerid++;
            CustomerID = "CID"+_customerid;
            Balance =  balance;
        }

        public CustomerRegistration(string data) 
        {
            string[] value = data.Split(',');
            _customerid = int.Parse(value[0].Remove(0,3));
            CustomerID = value[0];
            Balance = double.Parse(value[1]);
            Name = value[2];
            FatherName = value[3];
            Sex = Enum.Parse<Gender>(value[4], true); 
            Mobile = long.Parse(value[5]);
            DOB = DateTime.ParseExact(value[6], "dd/MM/yyyy", null);
            MailID = value[7];
            Location = value[8];

        }

        public void WalletRecharge(double amount)
        {
            Balance += amount;
        }

        
    }
}