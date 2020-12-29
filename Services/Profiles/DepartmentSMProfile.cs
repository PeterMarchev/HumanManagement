using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class DepartmentSMProfile : Profile
    {
        public DepartmentSMProfile()
        {
            CreateMap<Department, DepartmentSM>().ReverseMap();
        }
    }
}
