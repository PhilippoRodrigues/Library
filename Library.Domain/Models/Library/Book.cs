using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Models.Library
{
    public class Book
    {
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }

        public IList<AuthorBook> AuthorBook { get; set; }
    }
}
