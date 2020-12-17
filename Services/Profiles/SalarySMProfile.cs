using AutoMapper;
using Data;

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
