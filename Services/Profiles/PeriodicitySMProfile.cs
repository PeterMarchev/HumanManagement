using AutoMapper;
using Data;

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
