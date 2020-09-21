using Library.Domain.Interfaces;
using Library.Domain.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Data.Repositories
{
    public class AuthorRepository : IAuthor
    {

        private readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetById(int Id)
        {
            return _context.Authors.FirstOrDefault(a => a.AuthorId == Id);
        }

        public void Insert(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Update(Author author)
        {
            _context.Authors.Update(author);
        }
    }
}
