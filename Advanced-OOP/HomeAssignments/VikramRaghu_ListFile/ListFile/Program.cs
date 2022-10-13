namespace ListFile;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultValue();
    }

    static void DefaultValue()
    {
        List<StudentInfo> studentlist = new List<StudentInfo>();
        studentlist.Add(new StudentInfo(){Name="Vikram", FatherName="Raghu", Sex=Gender.Male, DOB=new DateTime(2001, 01, 11)});
        
        studentlist.Add(new StudentInfo(){Name="Emma", FatherName="Watson", Sex=Gender.Female, DOB=new DateTime(2001, 07, 18)});

        studentlist.Add(new StudentInfo(){Name="Daiys", FatherName="Rose", Sex=Gender.Female, DOB=new DateTime(2001, 01, 12)});
        
        Action.Insert(studentlist);
        Action.Display();

        Action.Update();
    
    }
}