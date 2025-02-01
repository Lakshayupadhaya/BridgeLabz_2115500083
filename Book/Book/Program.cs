using System;

class Book 
{
    private string title;
    private string author;
    private double price;

    public Book() 
    {
        title = "NA";
        author = "NA";
        price = 0.0;
    }

    public Book(string title) 
    {
        this.title = title;
        author = "NA";
        price = 0.0;
    }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        
    }
    public Book(string title, string author, float price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    static void Main(string[] args) 
    {
        Book book1 = new Book();
        Book book2 = new Book("Twilight");
        Book book3 = new Book("Gulliver Travels", "Jonathan Swift");
        Book book4 = new Book("Chronicles of Narnia", "C.S. Lewis", 1738);

        Console.WriteLine("Ttitle of the book is: "+ book1.title);
        Console.WriteLine("Author of the book is: "+ book1.author);
        Console.WriteLine("Price of the book is: " + book1.price);

        Console.WriteLine("Ttitle of the book is: " + book2.title);
        Console.WriteLine("Author of the book is: " + book2.author);
        Console.WriteLine("Price of the book is: " + book2.price);

        Console.WriteLine("Ttitle of the book is: " + book3.title);
        Console.WriteLine("Author of the book is: " + book3.author);
        Console.WriteLine("Price of the book is: " + book3.price);

        Console.WriteLine("Ttitle of the book is: " + book4.title);
        Console.WriteLine("Author of the book is: " + book4.author);
        Console.WriteLine("Price of the book is: " + book4.price);
    }
}
