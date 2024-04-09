public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool InStock { get; set; }
}

public class ConditionEncapsulationExample
{
    // Encapsulated condition method
    public bool IsProductAffordableAndAvailable(Product product)
    {
        // Check if the product is not null, the price is less than or equal to $100, and it is in stock
        return product is not null && product.Price <= 100 && product.InStock;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Encapsulate instantiation within a method
        RunExample();
    }

    static void RunExample()
    {
        ConditionEncapsulationExample example = new ConditionEncapsulationExample();

        Product product1 = new Product { Name = "Laptop", Price = 899.99m, InStock = true };
        Product product2 = new Product { Name = "Smartphone", Price = 299.99m, InStock = false };
        Product product3 = null; // Null product

        // Using the encapsulated condition method
        Console.WriteLine("Product 1 is affordable and available: " + example.IsProductAffordableAndAvailable(product1));
        Console.WriteLine("Product 2 is affordable and available: " + example.IsProductAffordableAndAvailable(product2));
        Console.WriteLine("Product 3 is affordable and available: " + example.IsProductAffordableAndAvailable(product3));
    }
}
