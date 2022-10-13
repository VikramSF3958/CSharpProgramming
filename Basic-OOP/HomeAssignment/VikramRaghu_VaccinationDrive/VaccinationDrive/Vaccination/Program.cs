using System;

namespace Vaccination;

class Program 
{
    public static void Main(string[] args)
    {
        Program obj = new Program();
        obj.Default();

        MainMenu.MainMenuView();
    }

    private void Default()
    {
        //Default Beneficiary
        Beneficiary Obj1 = new Beneficiary("Ravichandran", Gender.Male, 8484484, "Chennai", 21);
        MainMenu.BeneficiaryList.Add(Obj1);

        Beneficiary Obj2 = new Beneficiary("Baskaran", Gender.Male, 8484747, "Chennai", 21);
        MainMenu.BeneficiaryList.Add(Obj2);

        //Default Vaccine
        Vaccine vaccineObj1 =new Vaccine(vaccineName.CoviShield, 50);
        MainMenu.VaccineList.Add(vaccineObj1);

        Vaccine vaccineObj2 = new Vaccine(vaccineName.CoVaccine, 50);
        MainMenu.VaccineList.Add(vaccineObj2);

        //Default Vaccination
        VaccinationClass vaccineClassObj1 = new VaccinationClass("BID1001", "CID101", new DateTime(2021, 11, 11), 1);
        MainMenu.VaccinationList.Add(vaccineClassObj1);

        VaccinationClass vaccineClassObj2 = new VaccinationClass("BID1001", "CID101", new DateTime(2022, 03, 11), 2);
        MainMenu.VaccinationList.Add(vaccineClassObj2);

        VaccinationClass vaccineClassObj3 = new VaccinationClass("BID1002", "CID102", new DateTime(2022, 04, 04), 1);
        MainMenu.VaccinationList.Add(vaccineClassObj3);

    }
}