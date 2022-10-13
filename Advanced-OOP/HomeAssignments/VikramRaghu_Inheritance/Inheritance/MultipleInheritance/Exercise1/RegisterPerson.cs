

namespace Exercise1
{
    public class RegisterPerson : PersonalInfo, IShowData, IFamilyInfo
    {   
        private static int s_regNumber = 1000;
        public string RegistrationNumber { get; set; }

        public DateTime DateofReg { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public int SiblingsCount { get; set; }


        public RegisterPerson(DateTime dateofReg, string name, Gender sex, long phone, long mobile, Marital status, string fatherName, string motherName, int siblingCount):base(name, sex, phone, mobile, status)
        {
            s_regNumber++;
            RegistrationNumber = "RID" + s_regNumber;
            DateofReg = dateofReg;
            Sex = sex;
            FatherName = fatherName;
            MotherName = motherName;
            SiblingsCount = siblingCount;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("< ------------ INFO ----------------->");
            System.Console.WriteLine();

            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"MotherName: {MotherName}");
            System.Console.WriteLine($"Siblings Count: {SiblingsCount}");

            System.Console.WriteLine($"Date of Reg: {DateofReg}");
            System.Console.WriteLine($"Gender: {Sex}");
            System.Console.WriteLine($"PhoneNumber: {Phone}");
            System.Console.WriteLine($"Martial Status: {MaritalStatus}");


        }
    }
}