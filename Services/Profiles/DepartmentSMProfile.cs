using AutoMapper;
using Data;

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
