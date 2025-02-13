using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
namespace Bookstore

{
    public static class BookstoreBasicFunctions
    {
        public static Book? GetBookByTitle(string title)
        {
            using(var context = new Se407BookstoreContext())
            {
                return context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .FirstOrDefault(b => b.BookTitle == title);
            }
        }
        public static List<Book> GetAllBooks()
        {
            using (var context = new Se407BookstoreContext())
            {
                return context.Books
               .Include(b => b.Author)
               .Include(b => b.Genre) 
               .ToList();
            }
        }
        public static List<Book> GetBooksByAuthorLastName(string authorLastName)
        {
            using (var context = new Se407BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.AuthorLast == authorLastName)
                    .ToList();
            }
        }
    }
}
