using AutoMapper;
using ItServiceApp.Models.Identity;
using ItServiceApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.MapperProfiles
{
    public class AccountProfile:Profile
    {
        public AccountProfile()
        {
            CreateMap<ApplicationUser, UserProfileViewModel>().ReverseMap();
            //CreateMap<UserProfileViewModel, ApplicationUser>();//reversemap kullandığımız için gerek yok
        }
    }
}
