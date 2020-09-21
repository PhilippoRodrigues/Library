using AutoMapper;
using Library.Domain.Models.Library;
using Library.Web.Models.ViewModels.AuthorsViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Helpers
{
    public class LibraryMappings : Profile
    {
        public LibraryMappings()
        {
            CreateMap<Author, AuthorViewModel>();
        }
    }
}
