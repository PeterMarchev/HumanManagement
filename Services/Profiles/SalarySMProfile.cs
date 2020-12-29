using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class SalarySMProfile : Profile
    {
        public SalarySMProfile()
        {
            CreateMap<Salary, SalarySM>().ReverseMap();
        }
    }
}
