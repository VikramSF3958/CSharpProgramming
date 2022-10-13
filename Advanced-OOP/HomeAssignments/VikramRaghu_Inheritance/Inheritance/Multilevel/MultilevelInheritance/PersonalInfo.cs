
namespace MultiLevelInheritance
{   
    public enum Gender { Default, Male, Female, Transgender } 
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string  FatherName { get; set; }

        public long Phone { get; set; }

        public string  Mail { get; set; }

        public DateTime DOB { get; set; }

        public Gender Sex { get; set; }

        public PersonalInfo(string name, string fName, long phone, string mail, DateTime dob, Gender sex)
        {
            Name = name;
            FatherName = fName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Sex = sex;
        }
    }
}