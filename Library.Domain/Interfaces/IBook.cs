using Library.Domain.Models.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Interfaces
{
    public interface IBook
    {
        List<Book> GetAll();
        Book GetById(int Id);
        void Insert(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
