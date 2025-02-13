namespace Bookstore.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestBookByTitle()
        {
            var title = "Canterbury Tales";
            var book = BookstoreBasicFunctions.GetBookByTitle(title);
            Assert.NotNull(book);
            Assert.Equal(title, book.BookTitle);
        }
        [Fact]
        public void TestAllBooks()
        {
            int bookCount = BookstoreBasicFunctions.GetAllBooks().Count();
            Assert.Equal(3, bookCount);
        }
        [Fact]
        public void TestGetBookByAuthorLastName()
        {
            var books = BookstoreBasicFunctions.GetBooksByAuthorLastName("Martin");
            Assert.NotNull(books);
            //Space at end of Polo...
            Assert.Contains(books, b => b.BookTitle == "The Travels of Marco Polo ");
        }
    }
}