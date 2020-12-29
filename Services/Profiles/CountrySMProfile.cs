using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class CountrySMProfile : Profile
    {
        public CountrySMProfile()
        {
            CreateMap<Country, CountrySM>().ReverseMap();
        }
    }
}
