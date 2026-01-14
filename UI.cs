using BibliotheekbeheerSysteem;

namespace BibliotheekbeheerSysteem;

public class UI(Library libraryParameter) : IDisplayable
{
    public Library Library { get; set; } = libraryParameter;

    public void DisplayMenu()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("   Library Management System");
        Console.WriteLine("=================================");
        Console.WriteLine("Please select an option");
        Console.WriteLine("[1] Add book.\n[2] Delete book.\n[3] Search Book.\n[4] Display all books.\n[5] Close Program");
    }

    public void GetUserInput()
    {
        string userInputMenu = Console.ReadLine();
        if (userInputMenu == "1")
        {
            addUserBook();

        }
        else if (userInputMenu == "2")
        {
            Library.ListBooks();
            Console.WriteLine("type the number of book you want to delete.");
            int userInputBookNumber;
            while (!int.TryParse(Console.ReadLine(), out userInputBookNumber))
            {
                Console.WriteLine("Please enter a valid number:");
            }

        }
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

        // ask the user to go back to Main menu.
        string userInputShowMenu;

        do
        {
            Console.WriteLine("Type [ 0 ] to go back to main menu");
            userInputShowMenu = Console.ReadLine();

            if (userInputShowMenu != "0")
            {
                Console.WriteLine("Invalid input");
            }

        } while (userInputShowMenu != "0");

        DisplayMenu();
        GetUserInput();

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