using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Models.Library
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }

        public List<AuthorBook> AuthorBooks { get; set; }
    }
}
