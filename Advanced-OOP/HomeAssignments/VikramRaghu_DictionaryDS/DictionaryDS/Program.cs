namespace DictionaryDS;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.Clear();
        
        Dictionary<string, int> obj = new Dictionary<string, int>();
        obj.Add("vikram", 18);
        obj.Add("cool", 11);
        obj.Add("cool", 10);

        System.Console.WriteLine(obj["vikram"]);
        System.Console.WriteLine();
        System.Console.WriteLine("Before Updation");
        System.Console.WriteLine(obj["cool"]);
        System.Console.WriteLine("updated using Key");
        obj["cool"] = 21;
        System.Console.WriteLine(obj["cool"]);

        System.Console.WriteLine("Element AT:   ");
        for(int i=1; i<obj.Count+1; i++)
        {
            System.Console.WriteLine($"Key: {obj.ElementAt(i).Key} Value: {obj.ElementAt(i).Value} ");
        }

    }
}