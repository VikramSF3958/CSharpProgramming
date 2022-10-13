
namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        Defaultvalue();
    }

    static void Defaultvalue()
    {
        RegisterPerson obj = new RegisterPerson(new DateTime(2021, 10, 11), "Vikram", Gender.Male, 9898087, 987989, Marital.Single, "Raghu", "usha", 12);
        obj.ShowInfo();

        RegisterPerson ob1 = new RegisterPerson(new DateTime(2022, 11, 21), "Surya", Gender.Male, 98989087, 099887989, Marital.Single, "Deva", "Shree", 12);
        ob1.ShowInfo();
    }
}