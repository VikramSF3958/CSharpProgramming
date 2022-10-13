
namespace GroceryShop
{   
    public enum e_Gender { Default, Male, Female, Transgender }
    public class PersonalDetails
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public e_Gender Gender { get; set; }  

        public long MobileNumber { get; set; }

        public DateTime DOB { get; set; }

        public string MailId { get; set; }

        public PersonalDetails()
        {

        }

        public PersonalDetails(string name, string fathername, e_Gender gender, long mobileNumber, DateTime dob, string mailId)
        {
            Name = name;
            FatherName = fathername;
            Gender = gender;
            MobileNumber = mobileNumber;
            DOB = dob;
            MailId = mailId;
        }
    }
}