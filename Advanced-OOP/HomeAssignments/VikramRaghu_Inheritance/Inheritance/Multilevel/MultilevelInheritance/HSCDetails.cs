

namespace MultiLevelInheritance
{
    public class HSCDetails : StudentInfo
    {
        public string HSCMarksheetNumber { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public double Total { get; set; }

        public double  PercentageMarks { get; set; }

        public void calculate()
        {
            Total = (double)(Physics + Maths + Chemistry);
        }

        public HSCDetails(string hscmarksheet, int phy, int chemistry, int maths, int total, int percentmarks, string reg, string std, string branch, int year, string name, string fName, long phone, string mail, DateTime dob, Gender sex):base(reg, std, branch, year, name, fName, phone, mail, dob, sex)
        {
            HSCMarksheetNumber = hscmarksheet;
            Physics = phy;
            Chemistry = chemistry;
            Maths = maths;
            Total  = total;
            PercentageMarks  = percentmarks;
        }
        public  void ShowMarksheet()
        {
            System.Console.WriteLine("<------- MARK SHEET ------->");
            System.Console.WriteLine();
            System.Console.WriteLine($"HSCMarksheetNumber: {HSCMarksheetNumber}");
            System.Console.WriteLine($"Physics: {Physics}");
            System.Console.WriteLine($"Chemistry: {Chemistry}");
            System.Console.WriteLine($"Maths: {Maths}");
            System.Console.WriteLine($"Total: {Total}");
            System.Console.WriteLine($"PercentageMarks: {PercentageMarks}");

        }
    }
}