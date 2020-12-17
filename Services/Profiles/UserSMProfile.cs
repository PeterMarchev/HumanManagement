using AutoMapper;
using HumanManagement.Data.Identity.Entities;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class UserSMProfile : Profile
    {
        public UserSMProfile()
        {
            CreateMap<UserSM, WebUser>().ReverseMap();
        }
    }
}
