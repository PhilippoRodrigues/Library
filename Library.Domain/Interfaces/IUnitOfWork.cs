using Library.Domain.Models.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IBook Book { get; }
        IAuthor Author { get; }
        void Save();

    }
}
