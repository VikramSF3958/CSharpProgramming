
namespace OnlineMedicalStore
{   
    public enum o_status { Default, Purchased, Cancelled }
    public class OrderDetails
    {
       private static int _orderId = 2000;

       public string OrderId { get; set; } 

       public string UserId { get; set; }

       public string MedicineId { get; set; }

       public int MedicineCount { get; set; }

       public double TotalPrice { get; set; }

       public DateTime OrderDate { get; set; }

       public o_status Status { get; set; }

       public OrderDetails()
       {

       }

       public OrderDetails(string userid, string medId, int medCount, double totalPrice, DateTime orderDate, o_status status)
       {
        _orderId++;
        OrderId = "OID"+_orderId;
        UserId = userid;
        MedicineId = medId;
        MedicineCount = medCount;
        TotalPrice = totalPrice;
        OrderDate = orderDate;
        Status = status;
       }

       public OrderDetails(string data)
       {
        string[] values = data.Split(',');

        _orderId = int.Parse(values[0].Remove(0,3));
        OrderId = values[0];
        UserId = values[1];
        MedicineId = values[2];
        MedicineCount = int.Parse(values[3]);
        TotalPrice = double.Parse(values[4]);
        OrderDate = DateTime.ParseExact(values[5], "dd/MM/yyyy", null);
        Status = Enum.Parse<o_status>(values[6]);

       }

    }
}