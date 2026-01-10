/* 
This file is used to try out and test Book and Library methods.
It is not used in the final application.
*/

/* ###################################################################################################### */
//                                  Book class
/* ###################################################################################################### */
using System.Threading.Tasks.Dataflow;

Book book1  = new Book("Foundation", "Isaac Asimov", "9780553293357", 1951, "sifi");
Book book2  = new Book("Dune", "Frank Herbert", "9780441172719", 1965, "sifi");
Book book3  = new Book("1984", "George Orwell", "9780451524935", 1949, "sifi");

// Test AddBook()
Library library1 = new Library();
library1.AddBook(book1);
library1.AddBook(book2);
library1.AddBook(book3);
library1.ListBooks();


// Test DisplayDetails().
book1.DisplayDetails();


// Test IsMatch().
Console.WriteLine("Type a title or author you want to search.");

string userQueryTitle = "";

while (userQueryTitle == "")
{
    userQueryTitle = Console.ReadLine();

    if (userQueryTitle == "")
    {
        Console.WriteLine("Input cannot be empty. Please type a title or author:");
    }
}

bool matchTitle = book1.IsMatch(userQueryTitle);
Console.WriteLine(matchTitle);

/* ###################################################################################################### */
//                                      Library class
/* ###################################################################################################### */

/*
 public void CountBooks()
    {
        Console.WriteLine(books.Count);
    }
*/


// find index of book3
int x = library1.books.IndexOf(book3);
Console.WriteLine(x);

// delete book 3
library1.books.RemoveAt(2);
Console.WriteLine(library1.books[0].ISBN);

// Test CountBooks()
library1.CountBooks();

// Test AddBook()

Library bibliotheekRotterdam = new Library();

// Test RemoveBook() by Year
library1.RemoveBook("9780441172719");


// User input for removing book by ISBN
Console.WriteLine("Type de ISBN in om een boek te verwijderen.");
string userInputIsbn = Console.ReadLine();

// Test RemoveBook() by Year
library1.RemoveBook(userInputIsbn);

// Show all books after deleting book by ISBN.
library1.ListBooks();


/* ###################################################################################################### */
/* ###################################################################################################### */

