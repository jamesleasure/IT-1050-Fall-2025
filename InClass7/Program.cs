using System;

class Program
{
    static void Main(string[] args)
    {
        // Uses the default (parameterless) constructor
        Book book1 = new Book();
        book1.title = "The Art of Computer Programming";
        book1.author = "Donald Knuth";
        book1.numPages = 672;
        book1.genre = "Computer Science";
        book1.GoToPage(100);
        Console.WriteLine(book1.GetPage());
        book1.TurnPage();

        // Uses an overloaded constructor (different parameter list)
        Book book2 = new Book("Clean Code", "Robert C. Martin", 464, "Software Engineering");
        Console.WriteLine(book2.GetPage());

        // Composition in action: Book *has a* PageReader and delegates work to it
        book2.reader.ReadPage(book2.GetPage());

        // Polymorphism demonstration:
        // Both Book and PageReader define a method named PageLength(int),
        // so the same method name can be called on different types and behave differently.
        book2.PageLength(1);          // Calls Book.PageLength
        book2.reader.PageLength(1);   // Calls PageReader.PageLength

        // EBook inherits from Book (inheritance)
        EBook book3 = new EBook();
        book3.title = "Eloquent JavaScript";
    }
}

// Inheritance: EBook "is a" Book and automatically has Book's fields and methods
class EBook : Book
{
    
}

// Inheritance: PhysicalBook "is a" Book as well
class PhysicalBook : Book
{
    
}

class Book {
    // Public fields (not ideal for strict encapsulation, but okay for this example)
    public string title;
    public string author;
    public int numPages;
    public string genre;
    public bool finishedReading;

    // Information hiding: this field is private and cannot be accessed directly from outside
    private int currentPage;

    // Composition: Book "has a" PageReader object as a member
    public PageReader reader = new PageReader();

    // Constructor method (default / parameterless constructor)
    public Book()
    {
        this.currentPage = 1;
        this.finishedReading = false;
    }

    // Constructor method with 3 parameters
    // This is one overload of the Book constructor
    public Book(string title, string author, int totalPages) {
        this.title = title;
        this.author = author;
        numPages = totalPages;
        this.currentPage = 1;
        this.finishedReading = false;
    }
    
    // Constructor method with 4 parameters
    // Constructor overloading: same constructor name (Book) but different parameter list
    public Book(string title, string author, int totalPages, string genre) {
        this.title = title;
        this.author = author;
        numPages = totalPages;
        this.genre = genre;
        this.currentPage = 1;
        this.finishedReading = false;
    }

    // Same method name used in different classes (Book and PageReader)
    // participates in the polymorphism example in Main
    public int PageLength(int page)
    {
        return 100;
    }

    public bool GoToPage(int pageNumber) {
        if (pageNumber <= numPages) {
            currentPage = pageNumber;
            return true;
        }
            
        return false;
    }

    public void TurnPage() {
        currentPage++;
    }

    public void TurnPageBack() {
        currentPage--;
    }

    public void CompleteBook() {
        finishedReading = true;
    }

    // Encapsulation: this method provides controlled access to the private currentPage field
    public string GetPage() {
        // TODO: return current page number in a user-friendly way
        // Example:
        // return $"You are on page {currentPage} of {title}.";
        return "";
    }
}

class PageReader
{
    public void ReadPage(string page)
    {
        Console.WriteLine($"Reading page");
    }

    // Same method name as in Book (PageLength), used in the polymorphism example
    public int PageLength(int page)
    {
        return 100;
    }
}
