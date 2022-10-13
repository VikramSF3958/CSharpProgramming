
namespace Vaccination;
    public static class MainMenu
    {
        public static List<Beneficiary> BeneficiaryList = new List<Beneficiary>();
        public static List<VaccinationClass> VaccinationList = new List<VaccinationClass>();

        public static List<Vaccine> VaccineList = new List<Vaccine>();

        public static void MainMenuView()
        {
             Console.Clear();

            System.Console.WriteLine();
            System.Console.WriteLine("<------ VACCINATION DRIVE ------->");
            System.Console.WriteLine();

            string condition = "yes";

            while(condition == "yes")
            {
                Console.Clear();

                 System.Console.WriteLine("<------ VACCINATION DRIVE ------->");
                System.Console.WriteLine();
                System.Console.WriteLine("1.Beneficiary Registration\n2.User Login\n3.Get VaccineInfo\n4.Exit");
                System.Console.Write("Enter your Option: ");
                int Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {   
                    case 1:
                    {   
                        //User Registration
                        Registration();
                        System.Console.WriteLine("Press any key to go to Main Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        //User Login
                        Login();
                        System.Console.WriteLine("Press any key to go to Main Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {   
                        //Get vaccineInfo
                        Vaccine.ShowVaccine();
                        System.Console.WriteLine("Press any key to go to Main Menu...");
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {   
                        //Exit
                        System.Console.WriteLine("Exiting Main Menu...");
                        break;
                    }
                    
                    default:
                    {   
                        System.Console.WriteLine("Entered Option is NOT VALID");
                        System.Console.WriteLine("Please enter a valid Option");
                        break;
                    }
                }
            }
        }

        public static void Registration()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("<------ VACCINATION DRIVE ------->");
            System.Console.WriteLine();

            System.Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            
            System.Console.WriteLine("Enter the Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter the gender: ");
            Gender gender = Gender.Default;
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender );
            while(!temp || !((int)gender < 5 && (int) gender > 0))
            {
                System.Console.WriteLine("Invalid BloodType");
                System.Console.WriteLine("Enter Again: ");
                temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
            }

            System.Console.WriteLine("Enter the mobile Number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());


            System.Console.WriteLine("Enter the City:");
            string city = Console.ReadLine();

            Beneficiary beneficiaryObj = new Beneficiary(name, gender, phoneNumber, city, age);
            MainMenu.BeneficiaryList.Add(beneficiaryObj);

            System.Console.WriteLine($"Registered Successfully. Your Registration Number: {beneficiaryObj.RegistrationNumber}");
        }

        public static void Login()
        {   
            Console.Clear();
            System.Console.WriteLine("Login");
            System.Console.WriteLine();
            System.Console.Write("Enter your Registration Number: ");
            string userId = Console.ReadLine();
            
            bool check = true;
            foreach(Beneficiary userObj in BeneficiaryList)
            {   
                if(userObj.RegistrationNumber == userId)
                {
                    System.Console.WriteLine();
                    //Calling SubMenu
                    SubMenu.SubMenuView(userObj);
                    check = false;
                    break;
                }
            }
            if(check)
            {
                System.Console.WriteLine("Entered Registration is NOT Present");
            }

        }

    }
