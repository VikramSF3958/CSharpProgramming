namespace Exercise4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter 1st Number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter 2nd Number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter 3rd Number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        if(firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            System.Console.WriteLine($"{firstNumber} is the greatest among the three number");
        }
        else
        {
            if(secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                System.Console.WriteLine($"{secondNumber} is the greatest among the three number");
            }
            else
            {
                System.Console.WriteLine($"{thirdNumber} is the greatest among the three number");
            }
        }
    }
}