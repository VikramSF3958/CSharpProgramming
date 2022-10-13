

namespace Vaccination;
    public class VaccinationClass
    {
      private static int s_vaccinationID = 1000;

      public string VaccinationID { get; set; }

      public string VaccineID { get; set; }

      public string RegisterNumber { get; set; }  

      public int DoseNumber { get; set; }

      public DateTime VaccinateDate { get; set; }

      public VaccinationClass()
      {
      }

      public VaccinationClass(string registerNumber, string vaccineID, DateTime vaccineDate, int doseNumber)
      {
        s_vaccinationID++;
        VaccinationID = "VID" + s_vaccinationID;
        RegisterNumber = registerNumber;
        VaccineID = vaccineID;
        VaccinateDate = vaccineDate;
        DoseNumber = doseNumber; 
      }


    }
