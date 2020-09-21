using Library.Domain.Interfaces;
using Library.Domain.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Data.Repositories
{
    public class BookRepository : IBook
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetById(int Id)
        {
            return _context.Books.FirstOrDefault(b => b.BookId == Id);
        }

        public void Insert(Book book)
        {
            _context.Books.Add(book);
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
        }
    }
}
