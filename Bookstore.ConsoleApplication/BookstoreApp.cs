using Bookstore.Models;
using Bookstore;
using System;
using System.Collections.Generic;

public class BookstoreApp
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            faq();
            return;
        }
        static void faq()
        {
            Console.WriteLine("Some functions");
            Console.WriteLine("Go to debugger window in ConsoleApp Properties");
            Console.WriteLine("getbook TitleOfBook (with quotes around title)");
            Console.WriteLine("getallbooks");
            Console.WriteLine("getbooksbyauthor LastNameOfAuthor (with quotes around LastName");
        }
        {
            string command = args[0].ToLower();
            switch (command)
            {
                case "getbook":
                    HandleGetBookByTitle(args);
                    break;
                case "getallbooks":
                    HandleGetAllBooks();
                    break;
                case "getbooksbyauthor":
                    HandleGetBooksByAuthorLastName(args);
                    break;
                default:
                    break;
            }
        }
        static void HandleGetBookByTitle(string[] args)
        {
            string title = args[1];
            var book = BookstoreBasicFunctions.GetBookByTitle(title);

            if (book != null)
            {
                Console.WriteLine($"Found book: {book.BookTitle}");
                Console.WriteLine($"Author: {book.Author?.AuthorFirst}, {book.Author?.AuthorLast}");
                Console.WriteLine($"Genre: {book.Genre?.GenreType}");
            }
            else
            {
                Console.WriteLine($"No book found with title: {title}");
            }
        }
        static void HandleGetAllBooks()
        {
            var books = BookstoreBasicFunctions.GetAllBooks();

            Console.WriteLine("All Books:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.BookTitle} by {book.Author?.AuthorFirst}, {book.Author?.AuthorLast}");
            }
        }
        static void HandleGetBooksByAuthorLastName(string[] args)
        {
            string lastName = args[1];
            var books = BookstoreBasicFunctions.GetBooksByAuthorLastName(lastName);

            Console.WriteLine($"Books by author {lastName}:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.BookTitle}");
            }
            if (books.Count == 0)
            {
                Console.WriteLine("No books found.");
            }
        }
    }
}
