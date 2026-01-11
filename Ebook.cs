namespace BibliotheekbeheerSysteem;

public class Ebook : Book
{
    public double FileSize { get; private set; }

    public Ebook (string title, string author, string isbn, int publicationYear, string genre, double fileSize) : base (title, author, isbn, publicationYear, genre)
    {
        this. FileSize = fileSize;
    }
    
}