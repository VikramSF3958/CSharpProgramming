namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher("TID3000", "CSE", "Computer", 90, 5, DateTime.Now, "Priya", "Appan", new DateTime(1991, 01, 04), 8798798, e_Gender.Female, "priya@home.com");
        teacher.Show();

        System.Console.WriteLine();
        
        StudentInfo student = new StudentInfo("PID3000", "90", 5, new DateTime(2000, 10, 11), "JEEVA", "Perumal", new DateTime(2001, 01, 24), 9879879879, e_Gender.Male, "jeeva@hosur.com");
        student.Show();
    }
}