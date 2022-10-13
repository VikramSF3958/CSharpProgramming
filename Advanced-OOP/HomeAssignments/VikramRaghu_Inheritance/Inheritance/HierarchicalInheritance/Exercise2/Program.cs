namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        PermanentEmployee permanentEmployee = new PermanentEmployee("EPM3000", "PERMANENT", 15000, 12);
        permanentEmployee.CalculateSalary();
        permanentEmployee.ShowSalary();

        System.Console.WriteLine();

        TemporaryEmployee temporaryEmployee = new TemporaryEmployee("TEMP4000", "TEMPORARY" ,15000, 10);
        temporaryEmployee.CalculateSalary();
        temporaryEmployee.ShowSalary();
    }
}