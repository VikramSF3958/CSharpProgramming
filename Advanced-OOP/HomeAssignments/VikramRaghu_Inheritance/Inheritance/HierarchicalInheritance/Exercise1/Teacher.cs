
namespace Exercise1
{
    public class Teacher : PersonalInfo
    {
        public string TeacherID { get; set; }

        public string Department { get; set; }

        public string SubjectTeaching { get; set; }

        public double Qualification { get; set; }

        public int YearOfExerpience { get; set; }

        public DateTime DateOfJoining { get; set; }

        public Teacher()
        {

        }

        public Teacher(string teacherid, string department, string subjectTeaching, double qualification, int yearsExperience, DateTime dateOfJoining,string name, string fname, DateTime dob, long phone, e_Gender gender, string mail) : base (name, fname, dob, phone, gender, mail)
        {
            TeacherID = teacherid;
            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearOfExerpience = yearsExperience;
            DateOfJoining = dateOfJoining;
        }

        public new void Update()
        {

        }

        public new void Show()
        {
            System.Console.WriteLine($"TeacherID: {TeacherID}");
            System.Console.WriteLine($"Department: {Department}");
            System.Console.WriteLine($"SubjectTeaching: {SubjectTeaching}");
            System.Console.WriteLine($"Qualification: {Qualification}");
            System.Console.WriteLine($"YearOfExerpience: {YearOfExerpience}");
            System.Console.WriteLine($"DateOfJoining: {DateOfJoining}");

        }
    }
}