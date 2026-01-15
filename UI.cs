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
                AddUserBook();
            }
            else if (userInputMenu == "2")
            {
                Library.ListBooks();
                Console.WriteLine("type the ISBN of book you want to delete.");
                string userInputIsbn = Console.ReadLine();
                
                Library.RemoveBook(userInputIsbn);
            }
            else if (userInputMenu == "3")
            {
                Console.WriteLine("Type the title of the Book or name of the Author.");
                string query = Console.ReadLine();

                var results =  Library.SearchBooks(query);

                if (results.Count == 0)
                {
                    Console.WriteLine("No match found");
                } else
                {
                Library.prettify(results);
                }
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
    public void AddUserBook()
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