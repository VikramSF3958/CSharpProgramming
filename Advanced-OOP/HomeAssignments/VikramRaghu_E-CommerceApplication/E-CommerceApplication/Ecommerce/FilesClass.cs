namespace Ecommerce;

public static class FilesClass
{
    public static void Read()
    {
        string[] Customer = File.ReadAllLines("User/Customer.csv");

        foreach(string data in Customer)
        {
            MainMenu.customerDetailsList.Add(new CustomerDetails(data));
        }

        string[] Order = File.ReadAllLines("User/Order.csv");

        foreach(string data in Order)
        {
            MainMenu.orderDetailsList.Add(new OrderDetails(data));
        }

        string[] Product = File.ReadAllLines("User/Product.csv");

        foreach(string data in Product)
        {
            MainMenu.productDetailsList.Add(new ProductDetails(data));
        }
    }
    public static void Create()
    {
        //Creating Folder
        if(!Directory.Exists("User"))
        {
            System.Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("User");
        }
        else
        {
            System.Console.WriteLine("Folder already exists");
        }

        //Creating File
        if(!File.Exists("User/Customer.csv"))
        {
            File.Create("User/Customer.csv");
        }

        if(!File.Exists("User/Order.csv"))
        {
            File.Create("User/Order.csv");
        }

        if(!File.Exists("User/Product.csv"))
        {
            File.Create("User/Product.csv");
        }
    }

    public static void Write()
    {
        List<CustomerDetails> temp = MainMenu.customerDetailsList;
        string[] customerInfo = new string[temp.Count];

        for(int i=0; i<temp.Count;i++)
        {
            customerInfo[i] = temp[i].CustomerID+","+temp[i].CustomerName+","+temp[i].City+","+temp[i].MobileNumber+","+temp[i].WalletBalance+","+temp[i].EmailID;
        }

        File.WriteAllLines("User/Customer.csv", customerInfo);


        List<OrderDetails> temp1 = MainMenu.orderDetailsList;
        string[] orderInfo = new string[temp1.Count];

        for(int i=0; i<temp1.Count; i++)
        {
            orderInfo[i] = temp1[i].OrderId+","+temp1[i].CustomerID+","+temp1[i].ProductID+","+temp1[i].TotalPrice+","+temp1[i].PurchaseDate.ToString("dd/MM/yyyy")+","+temp1[i].Quantity+","+temp1[i].OrderStatus;
        }

        File.WriteAllLines("User/Order.csv", orderInfo);

        List<ProductDetails> temp3 = MainMenu.productDetailsList;
        string[] productInfo = new string[temp3.Count];

        for(int i=0; i<temp3.Count; i++)
        {
            productInfo[i] = temp3[i].ProductID+","+temp3[i].ProductName+","+temp3[i].Price+","+temp3[i].Stock+","+temp3[i].ShippingDuration;
        }

        File.WriteAllLines("User/Product.csv", productInfo);
    }

}