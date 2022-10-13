
namespace MainStudentAdmission
{
    public class DepartmentDetails
    {
        private int deparmentID = 101;

        public string DepartmentID { get; }

        public string DepartmentName { get; }

        public int NumberOfSeats { get; set;}

        public DepartmentDetails(string departmentID, string departmentName, int numberOfSeats)
        {

            DepartmentID = departmentID;
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
            
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