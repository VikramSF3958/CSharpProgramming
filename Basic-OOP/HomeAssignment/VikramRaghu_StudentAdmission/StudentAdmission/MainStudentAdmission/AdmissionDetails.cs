
namespace MainStudentAdmission
{   
    public enum admission { Default, Admitted, Canceled }
    public class AdmissionDetails
    {
        private int private_admissionId = 103;

        public string AdmissionID { get; set; }

        public string StudentID { get; set;}

        public string DepartmentID { get; set; }

        public DateTime AdmissionDate { get; set; }

        public admission AdmissionStatus { get; set; }

        public AdmissionDetails()
        {

        }

        public AdmissionDetails(string studentId, string departmentId, DateTime admissionDate, admission admissionStatus)
        {
            private_admissionId++;
            AdmissionID = "AID" + private_admissionId;
            StudentID = studentId;
            DepartmentID = departmentId;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;

        }

        public void TakeAdmission(string studentId_toFind, Registration registrationObj)
        {
            Mainmenunavigation.DepartmentSeatAvailablity();

            System.Console.WriteLine();
            System.Console.WriteLine("Choose your department by Entering the department ID: ");
            string departmentId = Console.ReadLine();

            int found = 0;

            DepartmentDetails tempDept = null;

            // looping through DepartmentsList
            foreach(DepartmentDetails departmentObject in Mainmenunavigation.departmentDetailsList)
            {   
                //Getting Department Id match
                if(departmentObject.DepartmentID == departmentId)
                {   
                    found = 1;
                    tempDept = departmentObject;
                    break;
                }
            }
            if(found==1)
            {   
                //System.Console.WriteLine("Found");
                if(registrationObj.CheckEligiblity(75))
                {
                   // System.Console.WriteLine("Eligible");
                   bool check = true;
                   foreach(AdmissionDetails admissionObject in Mainmenunavigation.admissionDetailsList)
                   {    
                        if(admissionObject.StudentID == registrationObj.StudentId && admissionObject.AdmissionStatus == admission.Admitted)
                        {
                            check = false;
                            break;
                        }
                   }

                   if(check)
                   {
                    AdmissionDetails newAdmission = new AdmissionDetails(registrationObj.StudentId, tempDept.DepartmentID, DateTime.Now, admission.Admitted);
                    Mainmenunavigation.admissionDetailsList.Add(newAdmission);
                    tempDept.NumberOfSeats--;
                    System.Console.WriteLine("Record Added Successfully");
                   }
                   else
                   {
                    System.Console.WriteLine("Already Admitted");
                   }
                }
                else
                {
                    System.Console.WriteLine("Not eligible");
                }
            }
            else
            {
                System.Console.WriteLine("Not found");
            }
            
            
        }

        public void ShowAdmissionDetails(Registration currentUser)
        {
            foreach(AdmissionDetails admissionObject in Mainmenunavigation.admissionDetailsList)
            {
                if(admissionObject.StudentID == currentUser.StudentId)
                {   
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Admission ID:  {admissionObject.AdmissionID}");
                    System.Console.WriteLine($"Student ID: {admissionObject.StudentID}");
                    System.Console.WriteLine($"Department ID: {admissionObject.DepartmentID}");
                    System.Console.WriteLine($"Admission Date: {admissionObject.AdmissionDate}");
                    System.Console.WriteLine($"Admission Status: {admissionObject.AdmissionStatus}");
                }
            }
        }

        public void CancelAdmission(Registration currentUser)
        {   
            int flag = 0;
            AdmissionDetails tempObject = null;
            foreach(AdmissionDetails admissionObject in Mainmenunavigation.admissionDetailsList)
            {   
                
                if(admissionObject.StudentID == currentUser.StudentId && admissionObject.AdmissionStatus == admission.Admitted)
                {
                    flag = 1;
                    tempObject = admissionObject;
                    break;
                }
            }

            if(flag == 1)
            {
               tempObject.AdmissionStatus = admission.Canceled;
               foreach(DepartmentDetails departmentTemp in Mainmenunavigation.departmentDetailsList)
               {
                    if(tempObject.DepartmentID == departmentTemp.DepartmentID)
                    {
                        departmentTemp.NumberOfSeats++;
                        break;
                    }
               } 
            }
        }
    }
}