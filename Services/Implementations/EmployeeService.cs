using AutoMapper;
using Data;
using HumanManagement.Data.Identity.Entities;
using HumanManagement.Data.Patterns;
using Microsoft.AspNetCore.Identity;
using Services.Interfaces;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly UserManager<WebUser> _userManager;

        public EmployeeService(IMapper mapper, IUnitOfWork uow, UserManager<WebUser> userManager)
        {
            _mapper = mapper;
            _uow = uow;
            _userManager = userManager;
        }

        public List<EmployeeSM> GetAllEmployees()
        {
            var employees = _uow.GetRepository<Employee>().GetAll();
            var mapping = _mapper.Map<List<Employee>, List<EmployeeSM>>(employees);
            return mapping;
        }
    }
}
