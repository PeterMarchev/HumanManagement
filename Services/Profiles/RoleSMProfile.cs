using AutoMapper;
using HumanManagement.Data.Identity.Entities;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class RoleSMProfile : Profile
    {
        public RoleSMProfile()
        {
            CreateMap<RoleSM, WebRole>().ReverseMap();
        }
    }
}
