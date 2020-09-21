using Library.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {

        private readonly LibraryContext _context;
        private IBook _bookRepo;
        private IAuthor _authorRepo;


        public UnitOfWorkRepository(LibraryContext context)
        {
            _context = context;
        }

        public IBook Book
        {
            get
            {
                return _bookRepo = _bookRepo ?? new BookRepository(_context);
            }
        }

        public IAuthor Author
        {
            get
            {
                return _authorRepo = _authorRepo ?? new AuthorRepository(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
