namespace ArrayListDS;

class Program 
{
    public static void Main(string[] args)
    {
        ArrayList obj = new ArrayList();
        obj.add("String");
        obj.add(18);
        obj.add(11.18);

        System.Console.WriteLine("Added three elements");
        System.Console.WriteLine(obj[0]);
        System.Console.WriteLine(obj[1]);
        System.Console.WriteLine(obj[2]);
        System.Console.WriteLine("Finding the element using index:");
        System.Console.WriteLine(obj.IndexOf(18.1));
        System.Console.WriteLine("Inserting 'Hie' at index - 1 and printing it ");
        obj.Insert(1, "Hie");

        System.Console.WriteLine(obj[1]);
        System.Console.WriteLine("After Removal of index - 1 print index - 1");
        obj.Remove("Hie");
        System.Console.WriteLine(obj[1]);

    }
}