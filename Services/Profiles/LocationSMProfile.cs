using AutoMapper;
using Data;

namespace Services.Profiles
{
    public class LocationSMProfile : Profile
    {
        public LocationSMProfile()
        {
            CreateMap<LocationSM, Location>().ReverseMap();
        }
    }
}
