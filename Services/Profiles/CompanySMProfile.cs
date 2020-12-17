using AutoMapper;
using Data;

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
