
namespace Exercise2
{
    public class TemporaryEmployee : SalaryInfo
    {   
        double DA, HRA, PF, TotalSalary;
        public string T_EmployeeID { get; set; }

        public string T_EmployeeType { get; set; }

        public TemporaryEmployee(string t_employeeid, string t_employeeType, double basicSalary, int month) : base(basicSalary, month)
        {   
            T_EmployeeID = t_employeeid;
            T_EmployeeType = t_employeeType;
            DA = 0.0015 * BasicSalary;
            HRA = 0.0013 * BasicSalary;
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