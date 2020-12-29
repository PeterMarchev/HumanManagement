using AutoMapper;
using Data;
using Services.ServiceModels;

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
