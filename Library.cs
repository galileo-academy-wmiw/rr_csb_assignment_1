
namespace BibliotheekbeheerSysteem;

public class Library
{
    private List<Book> books = new List<Book>();

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
        return -1;
    }
    public void RemoveBook(string isbn)
    {
        // first find the index
        int indexOfBook = FindIndexOfBook(isbn);
        // once i have the index
        if (indexOfBook == -1)
        {
            Console.WriteLine("ISBN bestaat niet, geen boeken verwijderd. Type een correcte ISBN in");
        }
        else
        {
            books.RemoveAt(indexOfBook);
        }
    }

    public List<Book> SearchBooks(string title)
    {
        var SearchResultByTitle = from b in books where b.Title.Contains(title) select b;
        return SearchResultByTitle.ToList();
    }

    // Helper method for prettify the result.
    public void prettify(List<Book> searchResult)
    {
        foreach (var item in searchResult)
        {
            item.DisplayDetails();
        }
    }
}

