using AutoMapper;
using Data;

namespace Services.Profiles
{
    public class SalaryHistorySMProfile : Profile
    {
        public SalaryHistorySMProfile()
        {
            CreateMap<SalaryHistorySM, SalaryHistory>().ReverseMap();
        }
    }
}
