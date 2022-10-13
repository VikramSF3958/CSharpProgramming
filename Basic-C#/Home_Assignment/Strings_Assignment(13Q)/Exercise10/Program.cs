using System; 

namespace Exercise10;

class Program 
{
    public static void Main(string[] args)
    {
        
        string[] usernames = new string[] {"Vikram", "Jeeva", "Kedi"};
        string[] passwords = new string[] {"kedi", "Deep", "vky"};

        System.Console.Write("Enter the username: ");
        string username = Console.ReadLine();
        
        System.Console.Write("Enter the password: ");
        string password = Console.ReadLine();

        int flag = 0;
        
        for(int i=0; i<username.Length; i++)
        {   
            if(username.Length > usernames[i].Length || password.Length > passwords[i].Length)
            {
                System.Console.WriteLine("inappropriate data entry");
                break;
            }
            if(username == usernames[i] && password == passwords[i])
            {
                flag = 1;
                break;
            }else
            {
                flag = 0;
            }
        }

        if(flag == 1)
        {
            System.Console.WriteLine("Successfull");
        }else
        {
            System.Console.WriteLine("Unsuccessful;");
        }
    }
}