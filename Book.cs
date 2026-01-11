namespace BibliotheekbeheerSysteem;

public class Book : IReadable 
{
    public string Title { get; private set; }

    public string Author { get; private set; }

    public string ISBN { get; private set; }

    public int PublicationYear { get; private set; }

    public string Genre { get; private set; }

    public Book(string title, string author, string isbn, int publicationYear, string genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        Genre = genre;
    }

    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        ISBN = " ISBN";
        PublicationYear = 0;
        Genre = "Unknown";
    }

    // Prints the details of this book to the console.
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Book details");
        Console.WriteLine($"-\nTitle:            {Title}\nAuthor:           {Author}\nISBN:             {ISBN}\nPublication Year: {PublicationYear}\n-");
    }

    public bool IsMatch(string searchQuery)
    {
        return searchQuery == Title || searchQuery == Author;
    }

    // Implementing Interface member method Read()
    public void Read()
    {
        Console.WriteLine($"{Title} is currently being read inside the library.");
    }
}

