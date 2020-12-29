using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class ScheduleSMProfile : Profile
    {
        public ScheduleSMProfile()
        {
            CreateMap<ScheduleSM, Schedule>().ReverseMap();
        }
    }
}
