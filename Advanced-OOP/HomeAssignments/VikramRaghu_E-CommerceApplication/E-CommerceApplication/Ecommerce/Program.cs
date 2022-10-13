using System;

namespace Ecommerce;

class Program 
{   
    
    public static void Main(string[] args)
    {   
        Console.Clear();
        System.Console.WriteLine("<-------- SYNCFUSION SHOP-STOP ----------->");
        
        // Program obj = new Program();
        // obj.DefaultValue();
        
        FilesClass.Read();

        //Invoking MainMenu
        MainMenu.Menu();

        //FilesClass.Create();
        FilesClass.Write();
    }

    void DefaultValue()
    {
        CustomerDetails customerObj = new CustomerDetails("Ravi", "Chennai", 9885858588, 50000, "ravi@mail.com");
        
        MainMenu.customerDetailsList.Add(customerObj);

        CustomerDetails customerObj1= new CustomerDetails("Baskaran", "Chennai", 9888475757, 60000, "baskaran@mail.com");
        MainMenu.customerDetailsList.Add(customerObj1);

        OrderDetails orderDetailsObj = new OrderDetails("CID1001", "PID101", 20000, DateTime.Now, 2, e_OrderStatus.Ordered);
        MainMenu.orderDetailsList.Add(orderDetailsObj);

        OrderDetails orderDetailsObj1 = new OrderDetails("CID1002", "PID103", 40000, DateTime.Now, 2, e_OrderStatus.Ordered);
        MainMenu.orderDetailsList.Add(orderDetailsObj1);

        ProductDetails productDetailsObj = new ProductDetails("Mobile", 10000, 10, 3);
        MainMenu.productDetailsList.Add(productDetailsObj);

        ProductDetails productDetailsObj1 = new ProductDetails("Tablet", 15000, 5, 2);
        MainMenu.productDetailsList.Add(productDetailsObj1);

        ProductDetails productDetailsObj2 = new ProductDetails("Camara", 20000, 3, 4);
        MainMenu.productDetailsList.Add(productDetailsObj2);

        ProductDetails productDetailsObj3 = new ProductDetails("iPhone", 50000, 5, 6);
        MainMenu.productDetailsList.Add(productDetailsObj3);

        ProductDetails productDetailsObj4 = new ProductDetails("Laptop", 40000, 3, 3);
        MainMenu.productDetailsList.Add(productDetailsObj4);

    }
}