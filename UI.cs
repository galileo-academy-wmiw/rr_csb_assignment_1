namespace BibliotheekbeheerSysteem;

public class UI : IDisplayable
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Select an option");
        Console.WriteLine("[1] Add book.\n[2] Delete book.\n[3] Search Book.\n[4] Display all books.\n[5] Close Program");
    }

    public static void GetUserInput()
    {
        string userInputMenu = Console.ReadLine();
        if (userInputMenu == "1") { Console.WriteLine("test mmsg: succesfully added 1 book"); }
        else if (userInputMenu == "2") { Console.WriteLine("test mssg: deleted 1 book"); }
        else if (userInputMenu == "3")
        {
            Console.WriteLine("test mmsg: showing search result");

        }
        else if (userInputMenu == "4") { 
            Console.WriteLine("Type the name of the library.");
            string userInputLibrayName = Console.ReadLine();
            
    
         }
        else if (userInputMenu == "5") { Console.WriteLine(" test mssg: closing program"); }
        else { Console.WriteLine("test mmsg: invalid option"); }
    }

    public void Run()
    {

    }
}