using AutoMapper;
using Data;

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
