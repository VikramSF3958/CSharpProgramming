
namespace ListFile
{
    public static class Action
    {
        public static void Insert( List<StudentInfo> studentlist)
        {
           StreamWriter write = null;

            if(!File.Exists("Data.csv"))
            {
                File.Create("Data.csv");
            }
            else
            {
                System.Console.WriteLine("File Already exists");
            }

            write = new StreamWriter(File.OpenWrite("Data.csv"));

            foreach(var v in  studentlist)
            {
                write.WriteLine(v.Name+","+v.FatherName+","+v.Sex+","+v.DOB.ToString("dd/MM/yyyy"));
            }

            write.Close();

            System.Console.WriteLine("Write SuccessFull");
        }

        public static void Display()
        {
            StreamReader reader = null;
            List<StudentInfo> studentInfosListA = new List<StudentInfo>();

            if(File.Exists("Data.csv"))
            {
                reader = new StreamReader(File.OpenRead("Data.csv"));

                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var values = line.Split(',');

                    if(values[0]!="")
                    {
                        studentInfosListA.Add(new StudentInfo(){ Name = values[0], FatherName = values[1], Sex = Enum.Parse<Gender>(values[2]), DOB = DateTime.ParseExact(values[3], "dd/MM/yyyy", null) });
                    }
                }

                reader.Close();
            }
            else
            {
                System.Console.WriteLine("File Doesn't Exist");
            }

            foreach(var temp in studentInfosListA)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Details");
                System.Console.WriteLine();
                System.Console.WriteLine($"Name: {temp.Name}");
                System.Console.WriteLine($"Father Name: {temp.FatherName}");
                System.Console.WriteLine($"Gender: {temp.Sex}");
                System.Console.WriteLine($"DOB: {temp.DOB}");
            }
        }

        public static void Update()
        {   
            System.Console.WriteLine("< -------------- UPDATE ----------------> ");
            StreamReader reader = null;
            List<StudentInfo> studentInfosListA = new List<StudentInfo>();

            if(File.Exists("Data.csv"))
            {
                reader = new StreamReader(File.OpenRead("Data.csv"));

                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var values = line.Split(',');

                    if(values[0]!="")
                    {
                        studentInfosListA.Add(new StudentInfo(){ Name = values[0], FatherName = values[1], Sex = Enum.Parse<Gender>(values[2]), DOB = DateTime.ParseExact(values[3], "dd/MM/yyyy", null) });
                    }
                }

                reader.Close();
            }
            else
            {
                System.Console.WriteLine("File Doesn't Exist");

            }

            StreamWriter write = null;

            if(File.Exists("Data.csv"))
            {
                write = new StreamWriter(File.OpenWrite("Data.csv"));

                System.Console.WriteLine("Enter the name of the Student to change: ");
                string studentname = Console.ReadLine();
            

                foreach(var v in  studentInfosListA)
                {  
                    if(v.Name == studentname)
                    {
                        System.Console.WriteLine("Enter name to change: ");
                        string name = Console.ReadLine();
                        v.Name = name;
                
                        System.Console.WriteLine("Enter father Name to change: ");
                        string fathername = Console.ReadLine();
                        v.FatherName = fathername;

                        write.WriteLine(v.Name+","+v.FatherName+","+v.Sex+","+v.DOB.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        write.WriteLine(v.Name+","+v.FatherName+","+v.Sex+","+v.DOB.ToString("dd/MM/yyyy"));
                    }
                    
                }

                System.Console.WriteLine("Data Updated");

                write.Close();

            }

        }
    }
}