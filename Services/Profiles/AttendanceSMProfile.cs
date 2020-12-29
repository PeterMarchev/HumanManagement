using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class AttendanceSMProfile : Profile
    {
        public AttendanceSMProfile()
        {
            CreateMap<Attendance, AttendanceSM>().ReverseMap();
        }
    }
}
