using AutoMapper;
using Data;
using Services.ServiceModels;

namespace Services.Profiles
{
    public class DepartmentManagerSMProfile : Profile
    {
        public DepartmentManagerSMProfile()
        {
            CreateMap<DepartmentManagerSM, DepartmentManager>().ReverseMap();
        }
    }
}
