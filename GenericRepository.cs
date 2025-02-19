public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
}


public class GenericRepository<T> where T : class
{
    private List<T> _dataStore = new List<T>();

    // Add entity to the repository
    public void Add(T entity)
    {
        _dataStore.Add(entity);
        Console.WriteLine($"{typeof(T).Name} added.");
    }

    // Retrieve all entities
    public IEnumerable<T> GetAll()
    {
        return _dataStore;
    }

    // Find by Id (assumes entity has a public Id property)
    public T FindById(int id)
    {
        var propertyInfo = typeof(T).GetProperty("Id");
        return _dataStore.FirstOrDefault(entity => (int)propertyInfo.GetValue(entity) == id);
    }
}


public class Program
{
    public static void Main()
    {
        // Create a repository for Product
        var productRepository = new GenericRepository<Product>();
        productRepository.Add(new Product { Id = 1, Name = "Laptop", Price = 1000.00M });
        productRepository.Add(new Product { Id = 2, Name = "Smartphone", Price = 500.00M });

        // Get all products
        var products = productRepository.GetAll();
        Console.WriteLine("Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }

        // Find a product by Id
        var foundProduct = productRepository.FindById(1);
        Console.WriteLine($"\nFound Product: Id: {foundProduct.Id}, Name: {foundProduct.Name}, Price: {foundProduct.Price}");

        // Create a repository for Customer
        var customerRepository = new GenericRepository<Customer>();
        customerRepository.Add(new Customer { Id = 1, FullName = "John Doe", Email = "john@example.com" });

        // Get all customers
        var customers = customerRepository.GetAll();
        Console.WriteLine("\nCustomers:");
        foreach (var customer in customers)
        {
            Console.WriteLine($"Id: {customer.Id}, Name: {customer.FullName}, Email: {customer.Email}");
        }
    }
}
