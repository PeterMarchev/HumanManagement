using AutoMapper;
using Data;

namespace Services.Profiles
{
    public class CountrySMProfile : Profile
    {
        public CountrySMProfile()
        {
            CreateMap<CountrySM, Country>().ReverseMap();
        }
    }
}
