using System;
class Book{
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public Book(string title, int publicationyear){
        Title = title;
        PublicationYear = publicationyear;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}
class Author : Book{
    public string AuthorName { get; set; }
    public string Bio { get; set; }
    public Author(string title, int publicationyear, string authorname, string bio) : base(title, publicationyear){
        AuthorName = authorname;
        Bio = bio;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Author Name: {AuthorName}");
        Console.WriteLine($"Bio: {Bio}\n");
    }
}
class Program{
    public static void Main(string[]args){
        Book book = new Book("OP", 1997);
        Author author = new Author("OP", 1997, "Oda", "Manga Artist");
        book.DisplayInfo();
        author.DisplayInfo();
    }
}
