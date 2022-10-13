
namespace Exercise1
{   
    
    public class StudentInfo : PersonalInfo
    {   
       
        private static int s_registerNumber = 1000;
        public string RegisterNumber { get; set; }

        public string Standard { get; set; }

        public string Branch { get; set; }

        public int AcademicYear { get; set; }

        public StudentInfo()
        {

        }

        public StudentInfo(string Std, string branch, int AcademicYr, string name, string fatherName, long phoneNumber, DateTime dob, Gender genderInfo):base(name, fatherName, phoneNumber, dob, genderInfo)
        {   
            s_registerNumber++;
            RegisterNumber = "REG" + s_registerNumber;
            Standard = Std;
            Branch = branch;
            AcademicYear = AcademicYr;
        }

        public void UpdateInfo(string Number)
        {   System.Console.WriteLine("< ---- Update Info ----->");
            foreach(StudentInfo tempObj in Program.studentList)
            {
                if(tempObj.RegisterNumber == Number)
                {
                    System.Console.WriteLine($"Change Standard: ");
                    tempObj.Standard = Console.ReadLine();
                    
                    System.Console.WriteLine($"Change Branch: ");
                    tempObj.Branch = Console.ReadLine();
                    
                    System.Console.WriteLine($"change Academic Year: ");
                    tempObj.AcademicYear = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"Change your Phone Number: ");
                    tempObj.Phone = long.Parse(Console.ReadLine());
                }
            }
        }

        public void ShowInfo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("< ---- Show Info ----->");
            System.Console.WriteLine();

            foreach(StudentInfo obj in Program.studentList)
            {     
                System.Console.WriteLine("< -------- Information ---------->");
                System.Console.WriteLine($"Register Number: {obj.RegisterNumber}");
                System.Console.WriteLine($"Name: {obj.Name}");
                System.Console.WriteLine($"Father Name: {obj.FatherName}");
                System.Console.WriteLine($"Phone Number: {obj.Phone}");
                System.Console.WriteLine($"Date of Birth: {obj.DOB}");
                System.Console.WriteLine($"Gender: {obj.GenderInfo}");
                System.Console.WriteLine($"Standard :{obj.Standard}");
                System.Console.WriteLine($"Branch :{obj.Branch}");
                System.Console.WriteLine($"Academic Year: {obj.AcademicYear}");
            }
        }
    }
}