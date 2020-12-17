using AutoMapper;
using Data;

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
