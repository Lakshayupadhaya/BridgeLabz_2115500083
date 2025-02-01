using System;

class Product 
{
    //attributes of products
    private string productName;//instance level attribute
    private int price;//instance level attribute
    private static int totalProducts;//class level attribute

    //Constructor chaining for handeling all types of parameters when creating products
    public Product() : this("", 0)
    { 
    }
    public Product(string productName) : this(productName, 0)
    {
    }
    public Product(int price) : this("", price)
    {
    }
    public Product(string productName, int price) 
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }
    //instance level method to print details of the product created(object)
    public void DisplayProductDetails() 
    {
        Console.WriteLine("Product details {0} {1}", this.productName, this.price);
    }

    //class level method to print total products created
    static void DisplayTotalProducts() 
    {
        Console.WriteLine("Total number of products created are: " + totalProducts); 
    }

    static void Main() 
    {
        Product product1 = new Product();
        product1.DisplayProductDetails();
        Product product2 = new Product("facewash");
        product2.DisplayProductDetails();
        Product product3 = new Product(300);
        product3.DisplayProductDetails();
        Product product4 = new Product("serum", 450);
        product4.DisplayProductDetails();

        DisplayTotalProducts();
    }
}