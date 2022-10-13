using System; 

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {

        DateTime dateTime = new DateTime();

        System.Console.WriteLine();
 
        System.Console.Write("Enter the Day in format (yyyy,MM,dd,hh,mm,ss,tt): ");
        dateTime = DateTime.ParseExact(Console.ReadLine(), "yyyy,MM,dd,hh,mm,ss,tt", null);

        System.Console.WriteLine($"Year: {dateTime.Year}");
        System.Console.WriteLine($"Month: {dateTime.Month}");
        System.Console.WriteLine($"Day: {dateTime.Day}");
        System.Console.WriteLine($"Hour: {dateTime.Hour}");
        System.Console.WriteLine($"Minute: {dateTime.Minute}");
        System.Console.WriteLine($"Second: {dateTime.Second}");
    }
}