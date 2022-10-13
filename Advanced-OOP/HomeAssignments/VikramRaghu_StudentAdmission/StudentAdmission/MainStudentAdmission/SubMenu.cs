
namespace MainStudentAdmission
{
    public static class SubMenu
    {
        public static void StudentLoginSubMenu(Registration obj)
        {   
            Console.Clear();
            string choice = "yes";

            while (choice == "yes")
            {   
                Console.Clear();
                System.Console.WriteLine("  Syncfusion College of Engineering and Technology    ");
                System.Console.WriteLine();
                System.Console.WriteLine($"Welcome! {obj.StudentName}");

                System.Console.WriteLine();
                System.Console.WriteLine("1.Eligiblity\n2.Show Details\n3.Take Admission\n4.Cancel Admission\n5.Admission Details\n6.Exit");
                System.Console.Write("Choose your option: ");

                int option = Convert.ToInt32(Console.ReadLine());


                switch(option)
                {   

                    case 1:
                    {   
                        System.Console.WriteLine();
                        System.Console.WriteLine("< ----- ELIGIBLITY CHECK -----> ");
                        System.Console.WriteLine();
                        if(obj.CheckEligiblity(75.0))
                        {
                            System.Console.WriteLine("You are Eligible");
                        }
                        else
                        {
                            System.Console.WriteLine("You are NOT Eligible");
                        }
                        System.Console.WriteLine();
                        System.Console.WriteLine("Press Any key to return to SubMenu");
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        System.Console.WriteLine("< ---- STUDENT DETAIL ----->");
                        System.Console.WriteLine();
                        obj.DisplayDetails();
                        System.Console.WriteLine();
                        System.Console.WriteLine("Press Any key to return to SubMenu");
                        Console.ReadKey();

                        break;
                    }

                    case 3:
                    {   
                        AdmissionDetails admissionObj = new AdmissionDetails();
                        admissionObj.TakeAdmission(obj.StudentId, obj);
                        System.Console.WriteLine("Press Any key to return to SubMenu");
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {
                        //Cancel Admission
                        AdmissionDetails admissionObj = new AdmissionDetails();
                        admissionObj.CancelAdmission(obj);
                        System.Console.WriteLine("Cancel Admission");
                        System.Console.WriteLine("Press Any key to return to SubMenu");
                        Console.ReadKey();
                        break;
                    }
                    
                    case 5:
                    {
                        //Show admission details
                        AdmissionDetails admissionObj = new AdmissionDetails();
                        admissionObj.ShowAdmissionDetails(obj);
                        System.Console.WriteLine("Shows admission details");
                        System.Console.WriteLine("Press Any key to return to SubMenu");
                        Console.ReadKey();
                        break;
                    }

                    case 6:
                    {
                        System.Console.WriteLine("Exiting SubMenu...");
                        choice = "no";
                        break;
                    }

                    default:
                    {
                        System.Console.WriteLine("Invalid Entry, Please try again");
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}