
namespace MultiLevelInheritance
{
    public class StudentInfo : PersonalInfo
    {
        public string RegisterNumber { get; set; }

        public string Standard { get; set; }

        public string  Branch { get; set; }

        public int AcademicYear { get; set; }

        public StudentInfo(string reg, string std, string branch, int year, string name, string fName, long phone, string mail, DateTime dob, Gender sex):base(name, fName, phone, mail, dob, sex)
        {
            RegisterNumber = reg;
            Standard = std;
            Branch = branch;
            AcademicYear = year;
        }

        public void UpdateInfo()
        {

        }

        public void ShowInfo()
        {   
            System.Console.WriteLine("Student Info");
            System.Console.WriteLine($"RegisterNumber: {RegisterNumber}");
            System.Console.WriteLine($"Standard: {Standard}");
            System.Console.WriteLine($"Branch: {Branch}");
            System.Console.WriteLine($"AcademicYear: {AcademicYear}");
        }
    }
}