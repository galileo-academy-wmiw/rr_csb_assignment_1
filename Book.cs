public class Book
{
    public string Title {get; private set;}

    public string Author {get; private set;}

    public double ISBN {get; private set;}

    public double PublicationYear {get; private set;}

    public string Genre {get; private set;}

    public Book (string title, string author, double isbn, double publicationYear, string genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        Genre = genre;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Book details");
        Console.WriteLine($"-\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}\n Publication Year: {PublicationYear}");
    }

    public bool IsMatch(string searchQuery)
    {
        if (searchQuery == Title || searchQuery == Author)
        {
            return true;
        }
    }
}