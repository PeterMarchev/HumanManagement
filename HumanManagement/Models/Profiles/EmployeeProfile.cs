using AutoMapper;
using HumanManagement.Models.ViewModels;
using Services.ServiceModels;

namespace HumanManagement.Models.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeSM, EmployeeVM>().ReverseMap();
            //CreateMap<EmployeeSM, EmployeeEditIM>().ReverseMap();
            //CreateMap<EmployeeSM, EmployeeCreateIM>().ReverseMap();

        }
    }
}
