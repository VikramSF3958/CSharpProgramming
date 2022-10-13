namespace Exercise3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Tata tata = new Tata("NEXON Electric", "NO899", "RC8090", "ENG98798", "CHS43543", 30, 5, 10000, new DateTime(2000, 10, 11));
            tata.Show();

            System.Console.WriteLine();

            Suzuki suzuki = new Suzuki("K10", "MODEL65456", "RC5454", "ENG433567", "CHS5678", 25, 4, 40900, new DateTime(2001, 10,11));
            suzuki.Show();
        }
    }
}