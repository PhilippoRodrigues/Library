using AutoMapper;
using Library.Domain.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
