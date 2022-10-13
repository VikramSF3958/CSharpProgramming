
namespace Vaccination;

    public enum vaccineName { Default, CoVaccine, CoviShield }
    public class Vaccine
    {
        private static int s_vaccineID = 100;

        public  string VaccineID { get; set;}

        public  vaccineName VaccineName { get; set; }

        public  int AvailableDose { get; set; }

        public Vaccine()
        {

        }

        public Vaccine(vaccineName vaccineName, int availableDose)
        {
            s_vaccineID++;
            VaccineID = "CID" + s_vaccineID;
            VaccineName = vaccineName;
            AvailableDose = availableDose;
        }

        public static void ShowVaccine()
        {   
            foreach(Vaccine obj in MainMenu.VaccineList)
            {
            System.Console.WriteLine();
            System.Console.WriteLine(" Vaccine Details ");
            System.Console.WriteLine($"VaccineID: {obj.VaccineID}");
            System.Console.WriteLine($"Taken Vaccine Name: {obj.VaccineName}");
            System.Console.WriteLine($"Number of Dose Available: {obj.AvailableDose}");
            System.Console.WriteLine();
            }
        }
    }
