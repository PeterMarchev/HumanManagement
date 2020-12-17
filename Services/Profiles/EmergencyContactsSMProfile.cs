using AutoMapper;
using Data;

namespace Services.Profiles
{
    public class EmergencyContactsSMProfile : Profile
    {
        public EmergencyContactsSMProfile()
        {
            CreateMap<EmergencyContactsSM, EmergencyContacts>().ReverseMap();
        }
    }
}
