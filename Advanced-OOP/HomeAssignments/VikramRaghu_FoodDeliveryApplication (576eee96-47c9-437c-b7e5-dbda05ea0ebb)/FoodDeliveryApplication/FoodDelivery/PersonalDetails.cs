
namespace FoodDelivery
{   
    public enum Gender { Default, Male, Female, Transgender }
    public class PersonalDetails
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Sex { get; set; }

        public long Mobile { get; set; }

        public DateTime DOB { get; set; }

        public string MailID { get; set; }

        public string Location { get; set; }

        public PersonalDetails()
        {
            
        }

        public PersonalDetails(string name, string fathername, Gender sex, long mobile, DateTime dob, string mailid, string location)
        {
            Name = name;
            FatherName = fathername;
            Sex = sex;
            Mobile = mobile;
            DOB = dob;
            MailID = mailid;
            Location = location;
        }

    }
}