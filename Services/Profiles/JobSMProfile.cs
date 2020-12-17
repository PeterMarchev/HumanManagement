using AutoMapper;
using Data;

namespace Services.Profiles
{
    public class JobSMProfile : Profile
    {
        public JobSMProfile()
        {
            CreateMap<JobSM, Job>().ReverseMap();
        }
    }
}
