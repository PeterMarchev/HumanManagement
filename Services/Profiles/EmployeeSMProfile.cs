using AutoMapper;
using Data;

namespace Services.Profiles
{
    public class EmployeeSMProfile : Profile
    {
        public EmployeeSMProfile()
        {
            CreateMap<EmployeeSM, Employee>().ReverseMap();
        }
    }
}
