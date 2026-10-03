using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("789 Oak Drive", "Dallas", "TX", "USA");
        Address address2 = new Address("456 Avenue", "Kinshasa", "Limete", "DRC");

        // Create customers
        Customer customer1 = new Customer("Alain Disasi", address1);
        Customer customer2 = new Customer("Christian Mavinga", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book of Mormon", "B001", 12.99m, 2));
        order1.AddProduct(new Product("Study Journal", "J101", 5.99m, 3));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bible", "B002", 15.50m, 1));
        order2.AddProduct(new Product("Marker Set", "M202", 3.25m, 4));

        // Display results
        DisplayOrder(order1);
        Console.WriteLine("----------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
    }
}
