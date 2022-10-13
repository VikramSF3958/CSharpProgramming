
namespace Vaccination;
    public static class SubMenu
    {
        public static void SubMenuView(Beneficiary currentUser)
        {
              string condition = "yes";

            while(condition == "yes")
            {   
                Console.Clear();
                System.Console.WriteLine($"Welcome, {currentUser.Name}");
                System.Console.WriteLine();
                 System.Console.WriteLine("<------ VACCINATION DRIVE ------->");
                System.Console.WriteLine();

                System.Console.WriteLine("1.Show My Details\n2.Take Vaccination\n3.My Vaccination History\n4.Next Due Date\n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {   
                    case 1:
                    {
                        //Show My Details
                        Beneficiary.ShowDetails(currentUser);
                        System.Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {
                        //Take Vaccination
                        TakeVaccine(currentUser);
                        System.Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {
                        //My Vaccination History
                        ShowHistory(currentUser);
                        System.Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {   
                        //Next Due Date
                        NextDueDate(currentUser);
                        System.Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }

                    case 5:
                    {
                        //Exit
                        System.Console.WriteLine("Exiting SubMenu...");
                        System.Console.WriteLine("Press any key to return to MainMenu...");
                        condition = "no";
                        Console.Clear();
                        break;
                    }


                    default:
                    {
                        System.Console.WriteLine("Invalid Option");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }

        public static void TakeVaccine(Beneficiary currentUser)
        {
            Vaccine.ShowVaccine();

            DateTime vaccineDate = new DateTime();
            bool check = false;
            int doseNumber = 0;
            int count = Beneficiary.DoseCount(currentUser);

            System.Console.WriteLine("Enter the Vaccination ID: ");
            string vaccineID = Console.ReadLine();

            foreach(Vaccine vaccineObj in MainMenu.VaccineList)
            {
                check = true;

                if(count == 3)
                {
                    System.Console.WriteLine("All three doses are Completed. !");
                }
                else
                {   
                    // Dosage Uses
                    if(count > 0 || count < 3)
                    {
                        foreach(VaccinationClass vaccineObj1 in MainMenu.VaccinationList)
                        {
                            if(vaccineObj1.RegisterNumber == currentUser.RegistrationNumber)
                            {
                                //Getting Vaccination date
                                vaccineDate = vaccineObj1.VaccinateDate;
                            }
                        }
                        if(count == 1)
                        {
                            if(vaccineID == vaccineObj.VaccineID)
                            {
                                if(vaccineDate.AddDays(30) <= DateTime.Now)
                                {
                                    check = true;
                                    doseNumber = 0;
                                    System.Console.WriteLine("You are eligible for vaccination");
                                    vaccineObj.AvailableDose--;
                                    doseNumber = 2;
                                    VaccinationClass newVaccination = new VaccinationClass(currentUser.RegistrationNumber, vaccineID, DateTime.Now, doseNumber);
                                    MainMenu.VaccinationList.Add(newVaccination);
                                }
                                else
                                {
                                    System.Console.WriteLine($"Your Due date is {vaccineDate.AddDays(30).ToString("dd/MM/yyyy")}");
                                }
                            }
                            else
                            {
                                check = false;
                            }
                        }
                        else if(count == 2)
                        {
                            if(vaccineID == vaccineObj.VaccineID)
                            {
                                if(vaccineDate.AddDays(30) <= DateTime.Now)
                                {
                                    check = true;
                                    doseNumber=0;
                                    System.Console.WriteLine("You are Eligible for Vaccination");
                                    vaccineObj.AvailableDose--;
                                    doseNumber = 3;

                                    VaccinationClass newVaccination = new VaccinationClass(currentUser.RegistrationNumber, vaccineID, DateTime.Now, doseNumber);
                                    MainMenu.VaccinationList.Add(newVaccination);
                                    System.Console.WriteLine("You are vaccinated Successfully");
                                }
                                else
                                {
                                    System.Console.WriteLine($"your date is {vaccineDate.AddDays(30).ToString("dd/MM/yyyy")}");
                                }
                            }
                            else
                            {   
                                check = false;
                                System.Console.WriteLine($"You can vaccinate with {vaccineObj.AvailableDose}");
                            }
                        }
                        else
                        {
                            if(vaccineID == vaccineObj.VaccineID)
                            {
                                if(vaccineDate.AddDays(30) <= DateTime.Now)
                                {
                                    check = true;
                                    doseNumber = 0;
                                    System.Console.WriteLine("You are eligible for vaccination");
                                    vaccineObj.AvailableDose--;
                                    doseNumber =1;
                                    VaccinationClass newVaccination = new VaccinationClass(currentUser.RegistrationNumber, vaccineID, DateTime.Now, doseNumber);
                                    MainMenu.VaccinationList.Add(newVaccination);
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("You are vaccinated Successfully");
                                }
                                else
                                {
                                    System.Console.WriteLine($"Your vaccination date is {vaccineDate.AddDays(30).ToString("dd/MM/yyyy")}");
                                }
                            }
                        }

                    }
                }
            }
        }

        public static void ShowHistory(Beneficiary currentUser)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("vaccination ID        Vaccine ID      Registration Number     Doses       Vaccinated Date");

            foreach(VaccinationClass obj in MainMenu.VaccinationList)
            {
                if(obj.RegisterNumber == currentUser.RegistrationNumber)
                {
                    System.Console.WriteLine($"{obj.VaccinationID}          {obj.VaccineID}         {obj.RegisterNumber}        {obj.DoseNumber}        {obj.VaccinateDate}");
                }
            }
        }
    
        public static void NextDueDate(Beneficiary currentUser)
        {
            DateTime DateObj = new DateTime();
            int dose = 0;
            foreach(VaccinationClass tempObj in MainMenu.VaccinationList)
            {
                if(tempObj.RegisterNumber == currentUser.RegistrationNumber)
                {
                    DateObj = tempObj.VaccinateDate;
                    dose = tempObj.DoseNumber;
                }
            }

            if(dose == 0)
            {
                System.Console.WriteLine($"Your Next Due Date is {DateTime.Now.ToString("dd/MM/yyyy")}");
            }
            else if(dose < 3)
            {
                System.Console.WriteLine($" Your Next Due is {DateTime.Now.ToString("dd/MM/yyyy")}");
            }
            else
            {
                System.Console.WriteLine($" You have completed the Vaccination ");
            }
        }
    }
