using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.DTOs.AnnouncementDTOs;
using TraversalCore.DTOs.AppUserDTOs;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Services.Mapping.AutoMapperProfile
{
    public class MapProfile :  Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();
            CreateMap<AppUserRegisterDto, AppUser>().ReverseMap();
            CreateMap<AppUserLoginDto, AppUser>();
        }
    }
}
