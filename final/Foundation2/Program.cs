public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Product[] products1 = { new Product("Product 1", 1, 10.50, 2), new Product("Product 2", 2, 5.25, 3) };
        Order order1 = new Order(customer1, products1);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Total cost: $" + order1.GetTotalCost());
        Console.WriteLine("Packing label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.GetShippingLabel());

        Address address2 = new Address("456 Oak St", "Othertown", "TX", "USA");
        Customer customer2 = new Customer("Jane Smith", address2);
        Product[] products2 = { new Product("Product 3", 3, 7.99, 1), new Product("Product 4", 4, 15.75, 2), new Product("Product 5", 5, 20.00, 1) };
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("Order 2:");
        Console.WriteLine("Total cost: $" + order2.GetTotalCost());
        Console.WriteLine("Packing label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.GetShippingLabel());