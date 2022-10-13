namespace GroceryShop;

class Program 
{  
    public static void Main(string[] args)
    {   
       //FilesData.Create();
        
        FilesData.Read();
        Operations.MainMethod();
        FilesData.Write();

    }
}