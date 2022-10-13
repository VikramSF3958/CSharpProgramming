
namespace Exercise1
{
    public class StudentInfo : PersonalInfo
    {
        public string PrincipalID { get; set; }

        public string S_Qualification { get; set; }

        public int S_YearsExperience { get; set; }

        public DateTime S_DateOfJoining { get; set; }

        public StudentInfo()
        {

        }

        public StudentInfo(string principalid, string s_qualification, int s_yearsExeperience, DateTime s_dateofJoining, string name, string fname, DateTime dob, long phone, e_Gender gender, string mail) : base(name, fname, dob, phone, gender, mail)
        {
            PrincipalID = principalid;
            S_Qualification = s_qualification;
            S_YearsExperience= s_yearsExeperience;
            S_DateOfJoining = s_dateofJoining;
        }

        public new void Update()
        {

        }

        public new void Show()
        {
            System.Console.WriteLine($"PrincipalID: {PrincipalID}");
            System.Console.WriteLine($"Student_Qualification: {S_Qualification}");
            System.Console.WriteLine($"Student_YearsExperience: {S_YearsExperience}");
            System.Console.WriteLine($"Student_DateOfJoining: {S_DateOfJoining}");

        }


    }
}