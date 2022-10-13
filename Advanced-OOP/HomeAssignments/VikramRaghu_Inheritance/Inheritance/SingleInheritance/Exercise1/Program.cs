using System;

namespace Exercise1;

class Program 
{   
    public static List<StudentInfo> studentList = new List<StudentInfo>();
    public static void Main(string[] args)
    {   
        
        DefaultValue();

        StudentInfo obj = new StudentInfo();
        obj.ShowInfo();

        System.Console.WriteLine();
        System.Console.WriteLine("Enter Register Number to Update: ");
        string Number = Console.ReadLine();
        obj.UpdateInfo(Number);

        System.Console.WriteLine();
        obj.ShowInfo();


        
    }

    private static void DefaultValue()
    {
        StudentInfo Obj1 = new StudentInfo("V", "CSE", 2022, "Vikram", "Raghu", 8220147225, new DateTime(2021, 10, 30), Gender.Male);
        studentList.Add(Obj1);

        StudentInfo Obj2 = new StudentInfo("VI", "CSE", 2021, "Jeeva", "Perumal", 82201485925, new DateTime(2030, 9, 18), Gender.Male);
        studentList.Add(Obj2);


    }
}