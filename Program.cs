

using BibliotheekbeheerSysteem;
Book book1 = new Book("Foundation", "Isaac Asimov", "9780553293357", 1951, "sifi");
Book book2 = new Book("Dune", "Frank Herbert", "9780441172719", 1965, "sifi");
Book book3 = new Book("1984", "George Orwell", "9780451524935", 1949, "sifi");

// Test AddBook()
Library library1 = new Library();
library1.AddBook(book1);
library1.AddBook(book2);
library1.AddBook(book3);

// Show all books
library1.ListBooks();

// User input for removing book by ISBN
Console.WriteLine("Type de ISBN in om een boek te verwijderen.");
string userInputIsbn = Console.ReadLine();

// Test RemoveBook() by Year
library1.RemoveBook(userInputIsbn);

// Show all books after deleting book by ISBN.
library1.ListBooks();


