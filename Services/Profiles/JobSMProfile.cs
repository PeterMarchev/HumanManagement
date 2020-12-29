using AutoMapper;
using Data;
using Services.ServiceModels;

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
