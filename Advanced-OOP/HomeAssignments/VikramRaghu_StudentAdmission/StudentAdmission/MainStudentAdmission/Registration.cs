
namespace MainStudentAdmission
{   
    public enum Gender { Default, Male, Female, Transgender }

    public  class Registration
    {   
        private static int studentId = 300;

        public string StudentId { get; set; }
        public  string StudentName { get; set; }

        public  string FatherName { get; set; }

        public  DateTime DOB { get; set; }

        public  Gender Gender { get; set; }

        public  int HSCMarksheetNumber { get; set; }

        public  int Physics { get; set; }

        public  int Chemistry { get; set; }

        public  int Maths { get; set; }

        public Registration()
        {
            
        }

        public Registration(string studentName, string fatherName, DateTime dob, Gender gender, int hscMarksheetNumber, int physics, int chemistry, int maths)
        {   
            StudentId = "SF"+studentId;
            studentId++;
            StudentName = studentName;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            HSCMarksheetNumber = hscMarksheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public Registration(string data)
        {
            string[] values = data.Split(',');
            studentId = int.Parse(values[0].Remove(0,2));
            StudentId = values[0];
            StudentName = values[1];
            FatherName = values[2];
            DOB = DateTime.ParseExact(values[3], "dd/MM/yyyy", null);
            Gender = Enum.Parse<Gender>(values[4]);
            HSCMarksheetNumber = int.Parse(values[5]);
            Physics = int.Parse(values[6]);
            Chemistry = int.Parse(values[7]);
            Maths = int.Parse(values[8]);
        }

        public bool CheckEligiblity(double cutoff)
        {
            double average = (Physics + Chemistry + Maths)/3.0;

            if(average >= 75.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayDetails()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("<---------- STUDENT DETAILS ----------->");
            System.Console.WriteLine();
            System.Console.WriteLine($"Student ID: {StudentId}");
            System.Console.WriteLine($"Student Name: {StudentName}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Date of Birth: {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"MarkSheet Number: {HSCMarksheetNumber}");
            System.Console.WriteLine($"Physics Mark: {Physics}");
            System.Console.WriteLine($"Chemistry Mark: {Chemistry}");
            System.Console.WriteLine($"Maths Mark: {Maths}");
        }
    }
}