public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool InStock { get; set; }
}

public class ConditionEncapsulationExample
{
    // Encapsulated condition method
    private bool IsProductAffordableAndAvailable(Product product)
    {
        // Check if the product is not null, the price is less than or equal to $100, and it is in stock
        return product is not null && product.Price <= 100 && product.InStock;
    }

    // Public method to access the encapsulated condition method
    public bool CheckProduct(Product product)
    {
        return IsProductAffordableAndAvailable(product);
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
        Console.WriteLine("Product 1 is affordable and available: " + (example.CheckProduct(product1) ? "yes" : "no"));
        Console.WriteLine("Product 2 is affordable and available: " + (example.CheckProduct(product2) ? "yes" : "no"));
        Console.WriteLine("Product 3 is affordable and available: " + (example.CheckProduct(product3) ? "yes" : "no"));
    }
}
