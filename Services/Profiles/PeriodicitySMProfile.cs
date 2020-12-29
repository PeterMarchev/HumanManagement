using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class PeriodicitySMProfile : Profile
    {
        public PeriodicitySMProfile()
        {
            CreateMap<PeriodicitySM, Periodicity>().ReverseMap();
        }
    }
}
