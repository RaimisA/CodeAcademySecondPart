using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ClassMethodsUzd
{
    internal class Library
    {
        List<Book> Books = new List<Book>();

        public void AddBook(string bookTitle)
        {
            Book book = new Book(bookTitle);
            Books.Add(book);
        }

        public void RemoveBook(string bookTitle)
        {
            var bookToRemove = Books.FirstOrDefault();
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
            }
        }
    }
}
