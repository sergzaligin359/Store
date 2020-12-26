using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C++ for 24 hours"),
            new Book(4, "JavaScript ninja!!!"),
            new Book(5, "History programming")

        };
        public Book[] GetAllByTitle(string titlePath)
        {
            return books.Where(book => book.Title.Contains(titlePath))
                    .ToArray();
        }
    }
}
