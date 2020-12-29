using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class CompanySMProfile : Profile
    {
        public CompanySMProfile()
        {
            CreateMap<Company, CompanySM>().ReverseMap();
        }
    }
}
