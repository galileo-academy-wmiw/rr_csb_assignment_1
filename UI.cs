namespace BibliotheekbeheerSysteem;
public class UI : IDisplayable
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Select an option");
        Console.WriteLine("[1] Add book.\n[2] Delete book.\n[3] Search Book.\n[4] Display all books.\n[5] Close Program");

    }

    public void GetUserInput() {}

    public void Run() {}
}