using AutoMapper;
using Data;

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
