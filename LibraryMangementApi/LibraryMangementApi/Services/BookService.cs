using LibraryMangementApi.Models;
//using LibraryMangementApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryMangementApi.Services
{
    public class BookService
    {
        // In-memory data structure to store books
        private static List<Book> _books = new List<Book>();

        // Get all books
        public List<Book> GetAllBooks()
        {
            return _books;
        }

        // Search books by title
        public List<Book> SearchBooksByTitle(string title)
        {
            return _books.Where(b => b.Title.Contains(title, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Get a book by ISBN
        public Book GetBookByISBN(string isbn)
        {
            return _books.FirstOrDefault(b => b.ISBN == isbn);
        }

        // Add a new book
        public void AddBook(Book newBook)
        {
            _books.Add(newBook);
        }

        // Update an existing book
        public void UpdateBook(Book existingBook, Book updatedBook)
        {
            existingBook.Title = updatedBook.Title;
            existingBook.Author = updatedBook.Author;
            existingBook.ISBN = updatedBook.ISBN;
            existingBook.Available = updatedBook.Available;
        }

        // Remove a book
        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }
    }
}