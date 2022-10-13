using System; 

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {

        DateTime dateTime = new DateTime();

        System.Console.WriteLine();
 
        System.Console.Write("Enter the Day in format (yyyy,MM,dd,hh,mm,ss,tt): ");
        dateTime = DateTime.ParseExact(Console.ReadLine(), "yyyy,MM,dd,hh,mm,ss,tt", null);

        System.Console.WriteLine($"Complete Date: {dateTime}");
        System.Console.WriteLine($"Short Date: {dateTime.ToShortDateString()}");
        System.Console.WriteLine($"Long Date: {dateTime.ToLongDateString()}");
        System.Console.WriteLine($"12hr format: {dateTime.ToString("hh:mm:ss tt")}");
        System.Console.WriteLine($"Date only: {dateTime.Date}");
        System.Console.WriteLine($"Time only: {dateTime.TimeOfDay}");

       

      
    }
}