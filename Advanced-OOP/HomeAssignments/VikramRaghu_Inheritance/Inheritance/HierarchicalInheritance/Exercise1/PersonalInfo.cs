
namespace Exercise1
{   
    public enum e_Gender { Default, Male, Female, Transgender }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public long Phone { get; set; }

        public e_Gender Gender { get; set; }

        public string Mail { get; set; }

        public PersonalInfo()
        {

        }

        public PersonalInfo(string name, string fname, DateTime dob, long phone, e_Gender gender, string mail)
        {
            Name = name;
            FatherName = fname;
            DOB = dob;
            Phone = phone;
            Gender = gender;
            Mail = mail;
        }

        public void Show()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"FatherName: {FatherName}");
            System.Console.WriteLine($"DOB: {DOB}");
            System.Console.WriteLine($"Phone: {Phone}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Mail: {Mail}");

        }

        public void Update()
        {

        }
    }
}