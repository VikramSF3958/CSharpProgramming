
namespace Exercise2
{
    public class PermanentEmployee : SalaryInfo
    {      
        double DA, HRA, PF, TotalSalary;
        public string EmployeeID { get; set; }

        public string EmployeeType { get; set; }

       

        public PermanentEmployee(string employeeid, string employeetype, double basicSalary, int month) : base(basicSalary, month)
        {
            EmployeeID = employeeid;
            EmployeeType = employeetype;
            DA = 0.002 * BasicSalary;
            HRA = 0.0018 * BasicSalary;
            PF = 0.001 * BasicSalary;
        }

        public void CalculateSalary()
        {
            TotalSalary = BasicSalary + DA + HRA - PF;

        }

        public void ShowSalary()
        {
            System.Console.WriteLine($"Total Salary: {TotalSalary}");
        }

    }
}