using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayRollManagement;

public enum worklocation { Default, Madura, Eymard};

public enum Gender { Default, Male, Female };

    public class EmployeeDetails
    {
       private static int s_employeeId = 1001;

       public String EmployeeId { get; set; }

        public String EmployeeName { get; set; }

        public String Role { get; set; }

        public worklocation Location { get; set; }

        public String  TeamName { get; set; }

        public DateTime DateOfJoin { get; set; }

        public int  WorkingDays { get; set; }

        public int LeaveTaken { get; set; }

        public Gender Gender { get; set; }

        public EmployeeDetails()
        {

        }
        public EmployeeDetails(String employeeName, String role, worklocation location, String teamName, DateTime dateOfJoining, int workingDays, int leaveTaken, Gender gender)
        {
            s_employeeId++;
            EmployeeId = "SF"+s_employeeId;
            EmployeeName = employeeName;
            Role = role;
            Location = location;
            TeamName = teamName;
            DateOfJoin = dateOfJoining;
            WorkingDays = workingDays;
            LeaveTaken = leaveTaken;
            Gender = gender;

        }
        public void CalculateSalary()
        {
            int salary = (WorkingDays - LeaveTaken) * 500;
            System.Console.WriteLine($"Salary of the Month: ${salary}");
        }





    }
