
namespace MainStudentAdmission;

    public static class Mainmenunavigation
    {   
        public static List<Registration> registrationList = new List<Registration>();
        public static List<DepartmentDetails> departmentDetailsList = new List<DepartmentDetails>();

        public static List<AdmissionDetails> admissionDetailsList = new List<AdmissionDetails>();
        private static  void DefaultValue()
        {   
            //REGISTRATION DETAILS Default
            Registration obj = new Registration("Ravichandran E", "Ettapparajan", new DateTime(1999, 11,11), Gender.Male, 123456 , 95, 95, 95);
            obj.StudentId = "SF3001";
            registrationList.Add(obj);

            Registration obj1 = new Registration("Baskaran S", "Sethurajan", new DateTime(1999, 11,11), Gender.Male, 123456 , 95, 95, 95);
            obj1.StudentId = "SF3002";
            registrationList.Add(obj1);
            
            //DEPARTMENT DETAILS Default
            DepartmentDetails departmentObj = new DepartmentDetails("DID101", "EEE", 29);
            departmentDetailsList.Add(departmentObj);

            DepartmentDetails departmentObj1 = new DepartmentDetails("DID102", "CSE", 29);
            departmentDetailsList.Add(departmentObj1);

            DepartmentDetails departmentObj2 = new DepartmentDetails("DID103", "MECH", 30);
            departmentDetailsList.Add(departmentObj2);

            DepartmentDetails departmentObj3 = new DepartmentDetails("DID104", "ECE", 30);
            departmentDetailsList.Add(departmentObj3);

            //ADMISSION DETAILS Default
            AdmissionDetails admissionObj = new AdmissionDetails("SF3001", "DID101", new DateTime(2022, 05, 11), admission.Admitted );
            admissionObj.AdmissionID = "AID1001";
            admissionDetailsList.Add(admissionObj);

            AdmissionDetails admissionObj1 = new AdmissionDetails("SF3002", "DID102", new DateTime(2022, 05, 12), admission.Admitted);
            admissionObj1.AdmissionID = "AID1002";
            admissionDetailsList.Add(admissionObj1);

        }
        
        public static void menu()
        {   
            DefaultValue();

            Console.Clear();
            
            string choice = "yes";

            while(choice == "yes")
            {   
                Console.Clear();
                System.Console.WriteLine("  Syncfusion College of Engineering and Technology    ");
                System.Console.WriteLine();

                System.Console.WriteLine("1.Student Registration \n2.Student Login \n3.Seat Availablity \n4.Exit");
                System.Console.Write("Enter the Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
            {   
                    case 1:
                    {   
                        StudentRegistration();
                        System.Console.WriteLine("Press Any key to return to Main Menu");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        StudentLogin();
                        System.Console.WriteLine("Press Any key to return to Main Menu");
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {   
                        DepartmentSeatAvailablity();
                        System.Console.WriteLine("Press Any key to return to Main Menu");
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {   
                        System.Console.WriteLine("Exiting Main Menu...");
                        System.Console.WriteLine("Press Any key to return to Exit MainMenu...");
                        Console.ReadKey();
                        choice = "no";
                        break;
                    }
                    
                    default:
                    {
                        System.Console.WriteLine("Invalid Option!, Again");
                        break;
                    }
            }
            
        }
    }

        public static void StudentRegistration()
    {   

        System.Console.WriteLine("  Syncfusion College of Engineering and Technology    ");
        System.Console.WriteLine();
        System.Console.WriteLine("<--------- REGISTER HERE ---------->");
        System.Console.WriteLine();
        System.Console.Write("Enter your Name: ");
        string studentName = Console.ReadLine();
        
        System.Console.Write("Enter your Father's Name: ");
        string fatherName  = Console.ReadLine();
        
        System.Console.Write("Enter your Date of Birth (dd/MM/yyyy):  ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        System.Console.Write("Your Gender: ");
        Gender gender = Gender.Default;
        bool temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
        while(!temp || !((int)gender < 4 && (int)gender > 0 ))
        {
            System.Console.Write("Invalid Gender !!!");
            System.Console.Write("Enter Again: ");
            temp = Enum.TryParse<Gender>(Console.ReadLine(),true,  out gender);
        }

        System.Console.Write("Enter your MarkSheet Number: ");
        int hscMarksheetNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter your Physics mark: ");
        int physicsMark = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter your Chemistry mark: ");
        int chemistryMark = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter your Maths mark: ");
        int mathsMark = Convert.ToInt32(Console.ReadLine());

        Registration obj = new Registration(studentName, fatherName, dob, gender, hscMarksheetNumber, physicsMark, chemistryMark, mathsMark);

        registrationList.Add(obj);

        System.Console.WriteLine();
        System.Console.WriteLine($"Registred Successfully !!!\n Your Registration Number is {obj.StudentId}");
        System.Console.WriteLine();
        
    }

        public static void StudentLogin()
        {   
            System.Console.WriteLine("  Syncfusion College of Engineering and Technology    ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("< ------- LOGIN --------->");
            System.Console.WriteLine();

            System.Console.Write("Enter your StudentID: ");
            string studentId = Console.ReadLine();
            
            foreach(Registration obj in registrationList)
            {
                if(obj.StudentId == studentId)
                {
                    System.Console.WriteLine("Login Successfull !!");
                    SubMenu.StudentLoginSubMenu(obj);
                }
                else
                {
                    System.Console.WriteLine("Sorry!, Couldn't find your record \n Please, Try Again");
                }
            }
        }

        public static void DepartmentSeatAvailablity()
        {
            System.Console.WriteLine("Department Seat availablity");
            System.Console.WriteLine();

            System.Console.WriteLine("Department ID:    Department Name:    Number of Seats Available");
            foreach(DepartmentDetails obj in departmentDetailsList)
            {
                System.Console.WriteLine($"{obj.DepartmentID}               {obj.DepartmentName}                {obj.NumberOfSeats}");
                System.Console.WriteLine();
            }

        }
    
    }
