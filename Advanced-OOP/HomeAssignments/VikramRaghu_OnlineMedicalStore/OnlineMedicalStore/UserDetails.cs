
namespace OnlineMedicalStore
{
    public class UserDetails
    {
        private static int _userid = 1000;

        public string UserID { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public long PhoneNumber { get; set; }

        public double Balance { get; set; }

        public UserDetails()
        {

        }

        public UserDetails(string userName, int age, string city, long phone, double balance)
        {
            _userid++;
            UserID = "UID"+_userid;
            UserName = userName;
            Age = age;
            City = city;
            PhoneNumber = phone;
            Balance = balance;
        }

        public UserDetails(string data)
        {
            string[] values = data.Split(',');

            _userid = int.Parse(values[0].Remove(0, 3));
            UserID = values[0];
            UserName = values[1];
            Age = int.Parse(values[2]);
            City = values[3];
            PhoneNumber = long.Parse(values[4]);
            Balance = double.Parse(values[5]);

        }
    }
}