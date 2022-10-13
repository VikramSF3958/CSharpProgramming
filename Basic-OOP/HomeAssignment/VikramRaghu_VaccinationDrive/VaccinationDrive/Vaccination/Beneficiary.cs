
namespace Vaccination;

    public enum Gender { Default, Male, Female, Transgender }
    public class Beneficiary
    {
        private static int s_RegistrationNumber = 1000;

        public  string RegistrationNumber { get; set; }

        public  string Name { get; set; }

        public  Gender Gender { get; set; }

        public  long PhoneNumber { get; set; }

        public  string City { get; set; }

        public  int Age { get; set; }


        public Beneficiary()
        {

        }

        public Beneficiary(string name, Gender gender, long phoneNumber, string city, int age)
        {
            s_RegistrationNumber++;
            RegistrationNumber = "BID" + s_RegistrationNumber;
            Name = name;
            Gender = gender;
            PhoneNumber = phoneNumber;
            City = city;
            Age = age;
        }

        public static void ShowDetails(Beneficiary currentUser)
        {   
            System.Console.WriteLine(" BENEFICIARY DETAILS ");
            System.Console.WriteLine($"Registration Number: {currentUser.RegistrationNumber}");
            System.Console.WriteLine($"Benefciary Name: {currentUser.Name}");
            System.Console.WriteLine($"Beneficiary Gender: {currentUser.Gender}");
            System.Console.WriteLine($"Beneficiary Phone Number: {currentUser.PhoneNumber}");
            System.Console.WriteLine($"Beneficiary City: {currentUser.City}");
            System.Console.WriteLine($"Beneficiary Age: {currentUser.Age}");
        }

        public static int DoseCount(Beneficiary currentUser)
        {
            int count = 0;
            foreach(VaccinationClass vaccine in MainMenu.VaccinationList)
            {
                if(vaccine.RegisterNumber == currentUser.RegistrationNumber)
                {
                    count++;
                }
            }

            return count;
        }



    }
