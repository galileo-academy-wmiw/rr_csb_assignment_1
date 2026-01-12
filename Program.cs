

using BibliotheekbeheerSysteem;
Book book1 = new Book("Foundation", "Isaac Asimov", "9780553293357", 1951, "sifi");
Book book2 = new Book("Dune", "Frank Herbert", "9780441172719", 1965, "sifi");
Book book3 = new Book("1984", "George Orwell", "9780451524935", 1949, "sifi");
Book Ebook1 = new Ebook("Neuromancer", "William Gibson", "9780441569595", 1984, "sci-fi", 10);

// Test AddBook()
Library library1 = new Library();
library1.AddBook(book1);
library1.AddBook(book2);
library1.AddBook(book3);
library1.AddBook(Ebook1);

// UI class
UI.DisplayMenu();
UI.GetUserInput();