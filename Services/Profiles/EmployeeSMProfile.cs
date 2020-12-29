using AutoMapper;
using Data;
using Services.ServiceModels;

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
