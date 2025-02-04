using System;
namespace LibraryManagementSystem{
    class Book{
        //Initialize variables
        public static string  libraryName="Nalanda Library";
        private string Title,Author;
        private readonly string ISBN;
        //method to display library name
        public static void DisplayLibraryName(){
            Console.WriteLine($"Library name is {libraryName}");
        }
        // parameterized constructor
        public Book(string title,string author,string ISBN){
            this.Title= title;
            this.Author=author;
            this.ISBN= ISBN;

        }
        //Method to Display the book Details
        public void DisplayBookDetails(){
            if(this is Book){
                DisplayLibraryName();
                Console.WriteLine($"The Title is: {Title}");
                Console.WriteLine($"The Author is : {Author}");
                Console.WriteLine($"The ISBN is : {ISBN}");
                Console.WriteLine("---------------------------------");
            }
        }
    }
    //Other class to call the Book Class
    class Program{
        static void Main(string[] args){
            //Make the instance of Book
            Book book1 =new Book("Wealth is power","XYZ","WXCN002");
            Book book2 = new Book("Cross The Legs","XYZ","NICR032");
            //call Display method
            book1.DisplayBookDetails();
            book2.DisplayBookDetails();
        }
    }
}
