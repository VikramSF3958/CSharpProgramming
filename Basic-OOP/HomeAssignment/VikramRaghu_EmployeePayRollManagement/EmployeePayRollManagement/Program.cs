using System;

namespace EmployeePayRollManagement;

class Program 
{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> employee = new List<EmployeeDetails>();

        System.Console.Write("Want to Add employee details: ");
        string wish = Console.ReadLine();
        
        while(wish == "yes")
        {
            System.Console.Write("Enter Employee Name: ");
            string employeeName = Console.ReadLine();

            System.Console.Write("Enter Employee Role: ");
            string employeeRole = Console.ReadLine();
            
            System.Console.Write("Enter Employee Work Location: ");
            worklocation location = Enum.Parse<worklocation>(Console.ReadLine(), true);

            System.Console.Write("Enter Employee Team Name: ");
            String teamName = Console.ReadLine();
            
            System.Console.Write("Enter Employee Date of Joining (dd/MM/yyyy): ");
            DateTime dateOFJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            System.Console.Write("Enter Employee working days in the month: ");
            int workingDays = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter Employee number of leave taken: ");
            int leaveTaken = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter Employee gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            EmployeeDetails obj = new EmployeeDetails(employeeName, employeeRole, location, teamName, dateOFJoining, workingDays, leaveTaken, gender);
            employee.Add(obj);

            System.Console.WriteLine();
            System.Console.WriteLine("  Data Added successfully ");

            System.Console.WriteLine();
            System.Console.Write("Want to Add employee details: ");
            wish = Console.ReadLine();


        }

        foreach(EmployeeDetails obj in employee)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Employee Name: {obj.EmployeeId}");
            System.Console.WriteLine($"Employee Role: {obj.Role}");
            System.Console.WriteLine($"Employee Location: {obj.Location}");
            System.Console.WriteLine($"Employee Team Name: {obj.TeamName}");
            System.Console.WriteLine($"Employee DOJ: {obj.DateOfJoin}");
            System.Console.WriteLine($"Employee Working days: {obj.WorkingDays}");
            System.Console.WriteLine($"Employee Leave taken: {obj.LeaveTaken}");
            System.Console.WriteLine($"Gender: {obj.Gender}");

            System.Console.WriteLine();
            obj.CalculateSalary();
        }
    }
}