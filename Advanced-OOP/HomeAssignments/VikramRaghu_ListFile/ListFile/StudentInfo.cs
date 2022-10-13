
namespace ListFile
{   
    public enum Gender { Default, Male, Female, Transgender } 
    public class StudentInfo 
    {
        public string Name { get; set; }

        public string  FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Sex { get; set; }

    }
}