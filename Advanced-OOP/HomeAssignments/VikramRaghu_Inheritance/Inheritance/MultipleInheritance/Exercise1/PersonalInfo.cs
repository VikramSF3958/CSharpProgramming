
namespace Exercise1
{   
    public enum Gender { Default, Male, Female }

    public enum Marital { Default, Married, Single }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public Gender Sex { get; set; }

        public long  Phone { get; set; }

        public long Mobile { get; set; }

        public Marital MaritalStatus { get; set; }

        public PersonalInfo(string name, Gender sex, long phone, long mobile, Marital status)
        {
            Name = name; 
            Phone = phone;
            Mobile = mobile;
            MaritalStatus = status;
            Phone = phone;
        }
    }
}