using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Online Ordering Program!");
        Console.WriteLine();

        Order order1 = new Order(new Customer("Edlyn Mae Apayart", new Address("R.Vasquez St.", "Nasugbu", "Batangas", "Philippines")));
        Order order2 = new Order(new Customer("Bradley Schmidt", new Address("143", "Masona", "New Washington", "USA")));
        Order order3 = new Order(new Customer("Skyler Hulse", new Address("Marty St.", "Riverdale", "California", "United States")));

        Console.Write("Order 1:");
        order1.AddProduct(new Product("Hair Straightener", 263839, 18.50, 1));
        order1.AddProduct(new Product("Hair Clip", 268293, 3.10, 3));
        Console.WriteLine();
        Console.WriteLine($"Packing label: {order1.GetPackingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Shipping label: {order1.GetShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        Console.Write("Order 2:");
        order2.AddProduct(new Product("Eyeliner", 142981, 8.20, 3));
        order2.AddProduct(new Product("Mascara", 126739, 15.00, 1));
        order2.AddProduct(new Product("Lipstick", 123892, 23.15, 1));
        Console.WriteLine();
        Console.WriteLine($"Packing label: {order2.GetPackingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Shipping label: {order2.GetShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine();

        Console.Write("Order 3:");
        order3.AddProduct(new Product("Christmas Tree", 183922, 68.90, 1));
        order3.AddProduct(new Product("Christmas Balls", 129738, 17.80, 3));
        Console.WriteLine();
        
        Console.WriteLine($"Packing label: {order3.GetPackingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Shipping label: {order3.GetShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order3.CalculateTotalCost():F2}");
        Console.WriteLine();
    }
}