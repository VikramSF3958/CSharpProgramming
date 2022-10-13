
namespace Exercise1
{   
    public enum Gender { Default, Male, Female, Transgender }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public DateTime DOB { get; set; }

        public Gender GenderInfo { get; set; }


        public PersonalInfo()
        {

        }

        public PersonalInfo(string name, string fatherName, long phoneNumber, DateTime dob, Gender genderInfo)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phoneNumber;
            DOB = dob;
            GenderInfo = genderInfo;
        }

    }
}