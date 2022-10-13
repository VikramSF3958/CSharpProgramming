
namespace MainStudentAdmission
{
    public static class FilesClass
    {
        public static void Create()
        {   
            //Creating Folder
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            else
            {
                System.Console.WriteLine("Folder Already Exists");
            }

            //Creating File
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            else
            {
                System.Console.WriteLine("College/StudentDetails.csv File Already Exists");
            }

            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/AdmissionDetails.csv");
            }
            else
            {
                System.Console.WriteLine("College/AdmissionDetails.csv File Already Exists");
            }

            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/DepartmentDetails.csv");
            }
            else
            {
                System.Console.WriteLine("College/DepartmentDetails.csv File Already Exists");
            }
        }
        
        public static void ReadFile()
        {
            string[] student = File.ReadAllLines("College/StudentDetails.csv");

            foreach(string data in student)
            {
                Mainmenunavigation.registrationList.Add(new Registration(data));
            }

            string[] admission = File.ReadAllLines("College/AdmissionDetails.csv");

            foreach(string data in admission)
            {       
                Mainmenunavigation.admissionDetailsList.Add(new AdmissionDetails(data));
            }

            string[] department = File.ReadAllLines("College/DepartmentDetails.csv");

            foreach(string data in department)
            {
                Mainmenunavigation.departmentDetailsList.Add(new DepartmentDetails(data));
            }
        }

        public static void WriteFile()
        {   
            List<Registration> temp = Mainmenunavigation.registrationList;
            string[] studentDetails = new string[temp.Count];

            for(int i=0; i<temp.Count;i++)
            {
                studentDetails[i] = temp[i].StudentId+","+temp[i].StudentName+","+temp[i].FatherName+","+temp[i].DOB.ToString("dd/MM/yyyy")+","+temp[i].Gender+","+temp[i].HSCMarksheetNumber+","+temp[i].Physics+","+temp[i].Chemistry+","+temp[i].Maths;
            }

            File.WriteAllLines("College/StudentDetails.csv", studentDetails);

            List<AdmissionDetails> temp1 = Mainmenunavigation.admissionDetailsList;
            string[] admissionDetails = new string[temp1.Count];

            for(int i=0; i<temp1.Count;i++)
            {
                admissionDetails[i] = temp1[i].AdmissionID+","+temp1[i].StudentID+","+temp1[i].DepartmentID+","+temp1[i].AdmissionDate.ToString("dd/MM/yyyy")+","+temp1[i].AdmissionStatus;
            }

            File.WriteAllLines("College/AdmissionDetails.csv", admissionDetails);


            List<DepartmentDetails> temp2 = Mainmenunavigation.departmentDetailsList;
            string[] departmentDetails = new string[temp2.Count];

            for(int i=0; i<temp2.Count; i++)
            {
                departmentDetails[i] = temp2[i].DepartmentID+","+temp2[i].DepartmentName+","+temp2[i].NumberOfSeats;
            }

            File.WriteAllLines("College/DepartmentDetails.csv", departmentDetails);
        }
    }
}