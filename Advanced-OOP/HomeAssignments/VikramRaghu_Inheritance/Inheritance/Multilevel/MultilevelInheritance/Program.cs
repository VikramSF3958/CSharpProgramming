namespace MultiLevelInheritance;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultValue();
    }

    static void DefaultValue()
    {
        HSCDetails obj = new HSCDetails("ID900", 100, 100, 100, 100, 100, "REG1098", "X", "CSE", 2001, "VK", "mr", 90798798, "vk@gmail.com", new DateTime(2021, 10, 11), Gender.Male);
        obj.ShowMarksheet();
        obj.ShowInfo();
    }
}