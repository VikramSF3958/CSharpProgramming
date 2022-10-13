
namespace MainStudentAdmission
{
    public class DepartmentDetails
    {
        private static int deparmentID = 101;

        public string DepartmentID { get; }

        public string DepartmentName { get; }

        public int NumberOfSeats { get; set;}

        public DepartmentDetails(string departmentID, string departmentName, int numberOfSeats)
        {
            deparmentID++;
            DepartmentID = "DID"+departmentID;
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
            
        }

        public DepartmentDetails(string data)
        {   
            string[] values = data.Split(",");
            DepartmentID = values[0];
            DepartmentName = values[1];
            NumberOfSeats = int.Parse(values[2]);
        }
        public void SeatAvailablity()
        {
            System.Console.WriteLine("  Seat Availablity ");
            System.Console.WriteLine($"Department Id: {DepartmentID}");
            System.Console.WriteLine($"DepartmentName: {DepartmentName}");
            System.Console.WriteLine($"NumberOfSeats :{NumberOfSeats}");
        }
    }
}