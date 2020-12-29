using AutoMapper;
using Data;
using Services.ServiceModels;

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
