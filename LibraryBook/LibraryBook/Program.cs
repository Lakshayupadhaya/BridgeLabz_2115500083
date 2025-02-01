using System;

class LibraryBook 
{
    // attributes of book
    private string title;
    private string author;
    private double price;
    private bool availability;
    // default constructer is required because when you create a instance to borrow a book it will have no parameters 
    // causing issue so we use it initialize the attributes of that object on instance
    public LibraryBook() 
    {
        title = string.Empty;
        author = string.Empty;
        price = 0;
        availability = false;
    }
    // constructor to assign values to the book
    public LibraryBook(string title, string author, double price, bool availability)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }
    // method to borrow book 
    private void BorrowBook(LibraryBook book)
    {
        if (book.availability)//if the book is available create the book for borrowed
        {
            this.title = book.title;
            this.author = book.author;
            this.price = book.price;
            this.availability = false;
        }
        else
        {
            Console.WriteLine("Book is not available");//if the book is not available
        }
    }

    static void Main(string[] args) 
    {
        LibraryBook book1 = new LibraryBook("Twilight", "Joanathan", 2314, true);
        LibraryBook book3 = new LibraryBook("Chronicles of narnia", "Lakshay", 2344, false);

        LibraryBook book2 = new LibraryBook();//making a instance to borrow a book if available
        book2.BorrowBook(book1);// checking if the book is available and allocating it 

        LibraryBook book4 = new LibraryBook();//creating a book to borrow
        

        Console.WriteLine(book1.title);
        Console.WriteLine(book2.author);
        Console.WriteLine(book1.price);
        Console.WriteLine(book2.title);
        Console.WriteLine(book2.author);
        Console.WriteLine(book2.price);

        book4.BorrowBook(book3);//trying to borrow a non available book
    }
}