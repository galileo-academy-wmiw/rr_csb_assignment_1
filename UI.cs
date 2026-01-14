using BibliotheekbeheerSysteem;

namespace BibliotheekbeheerSysteem;

public class UI(Library libraryParameter) : IDisplayable
{
    public Library Library { get; set; } = libraryParameter;

    public void DisplayMenu()
    {
        Console.WriteLine("Select an option");
        Console.WriteLine("[1] Add book.\n[2] Delete book.\n[3] Search Book.\n[4] Display all books.\n[5] Close Program");
    }

    public void GetUserInput()
    {
        string userInputMenu = Console.ReadLine();
        if (userInputMenu == "1")
        {
            addUserBook();
        }
        else if (userInputMenu == "2") { Console.WriteLine("test mssg: deleted 1 book"); }
        else if (userInputMenu == "3")
        {
            Console.WriteLine("test mmsg: showing search result");
        }
        else if (userInputMenu == "4")
        {
            Library.ListBooks();
        }
        else if (userInputMenu == "5") { Console.WriteLine(" test mssg: closing program"); }
        else { Console.WriteLine("test mmsg: invalid option"); }
    }

    public void Run()
    {
        
    }

    // helper method for adding user book. 
    public void addUserBook()
    {
        Console.WriteLine("enter a title");
        string title = Console.ReadLine();

        Console.WriteLine("enter author");
        string author = Console.ReadLine();

        Console.WriteLine("enter isbn");
        string isbn = Console.ReadLine();

        Console.WriteLine("Enter publication year:");

        int year;
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Please enter a valid number:");
        }

        Console.WriteLine("enter Genre");
        string genre = Console.ReadLine();

        Book userbook = new Book(title, author, isbn, year, genre);
        libraryParameter.AddBook(userbook);
        
        Console.WriteLine("Your book has been added to the library Rotterdam.");
        userbook.DisplayDetails();

    }

}