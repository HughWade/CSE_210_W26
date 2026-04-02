using System;

class Program
{
    static void Main(string[] args)
    {
    Address address = new Address();
    Customer customer1 = new Customer("Hugh Wade", address);
    

    // First order, 3 products
    Order Order1 = new Order(customer1, address);
    Product product11 = new Product("Baby Doll", "20574", 11, 1);
    Product product12 = new Product("Camcorder","04839", 24, 2);
    Product product13 = new Product("Blue Jeans", "38593", 19, 3);
    Order1.AddToList(product11);
    Order1.AddToList(product12);
    Order1.AddToList(product13);
    Console.WriteLine(Order1.PackagingLabel());
    Console.WriteLine(Order1.ShippingLabel(customer1));
    Console.WriteLine($"\nTotal Cost of Order - ${Order1.GetTotalCostOfOrder()}");
    Console.WriteLine("----------------------------------\n");
    

    // Second order, 3 products
    Order Order2 = new Order(customer1, address);
    Product product21 = new Product("Computer Mouse", "85729", 23, 4);
    Product product22 = new Product("Hand Lotion", "32859", 9, 3);
    Product product23 = new Product("Laundry Detergent", "38503", 12, 1);
    Order2.AddToList(product21);
    Order2.AddToList(product22);
    Order2.AddToList(product23);
    Console.WriteLine(Order2.PackagingLabel());
    Console.WriteLine(Order2.ShippingLabel(customer1));
    Console.WriteLine($"\nTotal Cost of Order - ${Order2.GetTotalCostOfOrder()}");
    Console.WriteLine("----------------------------------\n");


    // Third order, 3 products
    Order Order3 = new Order(customer1, address);
    Product product31 = new Product("Picture of Christ", "11111", 5, 10);
    Product product32 = new Product("White Shirt", "32840", 25, 3);
    Product product33 = new Product("Tie Clip", "75893", 5, 5);
    Order3.AddToList(product31);
    Order3.AddToList(product32);
    Order3.AddToList(product33);
    Console.WriteLine(Order3.PackagingLabel());
    Console.WriteLine(Order3.ShippingLabel(customer1));
    Console.WriteLine($"\nTotal Cost of Order - ${Order3.GetTotalCostOfOrder()}");
    Console.WriteLine("----------------------------------\n");


    }
}