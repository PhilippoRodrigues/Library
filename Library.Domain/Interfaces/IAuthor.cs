using Library.Domain.Models.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Interfaces
{
    public interface IAuthor
    {
        List<Author> GetAll();
        Author GetById(int Id);
        void Insert(Author author);
        void Update(Author author);
        void Delete(Author author);
    }
}
