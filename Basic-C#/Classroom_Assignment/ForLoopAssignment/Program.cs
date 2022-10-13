namespace FORLOOPAssignemnt;

class Program
{
    public static void Main(string[] args)
    {
        for(int i=0; i<=25; i++)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }
        }

        System.Console.Write("Enter Initial value: ");
        int initialValue = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter Final Value: ");
        int finalValue = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for(int i=initialValue; i<=finalValue; i++)
        {
            sum += i*i;
        }
        System.Console.WriteLine($"Sum of Square: {sum}");
    }
}