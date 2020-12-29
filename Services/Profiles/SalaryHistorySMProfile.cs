using AutoMapper;
using Data;
using Services.ServiceModels;

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
