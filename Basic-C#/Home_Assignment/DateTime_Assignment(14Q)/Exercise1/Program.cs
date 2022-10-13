using System; 

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the times you want to enter the data: ");
        int repeat = Convert.ToInt32(Console.ReadLine());

        DateTime[] arrayDateTime = new DateTime[repeat];

        System.Console.WriteLine();

        for(int i=0; i<repeat; i++)
        {   
            System.Console.Write("Enter the Day in format (yyyy/MM/dd hh:mm:ss tt): ");
            arrayDateTime[i] = DateTime.ParseExact(Console.ReadLine(), "yyyy,MM,dd,hh,mm,ss,tt", null);
        }

        for(int i=0; i<repeat; i++)
        {
            System.Console.WriteLine($"Date: {arrayDateTime[i].Date} and Time: {arrayDateTime[i].TimeOfDay}");
            System.Console.WriteLine($"Date: {arrayDateTime[i].ToString("yyyy/MM/dd")} and Time: {arrayDateTime[i].ToString("hh:mm:ss tt")}");

        }
    }
}