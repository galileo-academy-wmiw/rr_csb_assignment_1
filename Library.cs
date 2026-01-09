
namespace BibliotheekbeheerSysteem;

public class Library
{
    public List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }
    // Show all books. Sorted by title !!
    public void ListBooks()
    {
        Console.WriteLine("**** Display All Books ***");
        foreach (Book item in books)
        {
            item.DisplayDetails();
        }
    }

    // test method: count List 


    public int FindIndexOfBook(string isbn)
    {
        // books.Find();
        for (int i = 0; i < books.Count; i++)
        {
            if (isbn == books[i].ISBN)
            {
                return i;
            }
        }
            return -1;   // I still dont understand this part !!!!!!!!!!!!!!!!!!!!!!!
    }
    public void RemoveBook(string isbn)
    {
        // first find the index
        int indexOfBook = FindIndexOfBook(isbn);
        // once i have the index
        books.RemoveAt(indexOfBook);

    }
}