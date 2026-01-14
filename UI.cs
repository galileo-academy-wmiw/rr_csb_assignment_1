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

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            DisplayMenu();
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
                Console.WriteLine("Type the title of the Book or name of the Author.");
                string query = Console.ReadLine();
                Library.SearchBooks(query);
            }
            else if (userInputMenu == "4")
            {
                Library.ListBooks();
            }
            else if (userInputMenu == "5")
            {
                Console.WriteLine("Closing program. Goodbye!");
                isRunning = false;
            }

            else { Console.WriteLine("invalid option please enter a option from 1 , 2 3, or 5 "); }


            if (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Press ENTER to return to the main menu...");
                Console.ReadLine();
            }
        }
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