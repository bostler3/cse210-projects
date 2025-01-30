using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address order1CustomerAddress = new Address("123 Cornerflag Lane", "Los Angeles", "CA", "USA");
    
        Customer order1Customer = new Customer("Soccer Mom Mary", order1CustomerAddress);
        
        Product order1Product1 = new Product("Soccer ball", "SB1", 5.50m, 3);
        Product order1Product2 = new Product("Cleats", "CT4", 6.69m, 1);
        Product order1Product3 = new Product("Shinguards", "SH009", 10m, 2);
        
        Order order1 = new Order(order1Customer);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        order1.AddProduct(order1Product3);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");
        order1.Display();
        Console.WriteLine("");
        
        Address order2CustomerAddress = new Address("456 Football Street", "Tijuana", "Baja California", "Mexico");
        
        Customer order2Customer = new Customer("Super Bowl Stu", order2CustomerAddress);
        
        Product order2Product1 = new Product("Football", "FOOT354", 65.25m, 1);
        Product order2Product2 = new Product("T-shirt", "TS00683", 37m, 1);
        Product order2Product3 = new Product("Cup", "C905", 25m, 2);
        
        Order order2 = new Order(order2Customer);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        order2.Display();
    }
}