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
using System.Threading.Tasks;

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

        public async Task<EmployeeSM> GetEmployeeByIdAsync(object id)
        {
            var employee = await _uow.GetRepository<Employee>().GetByIdAsync(id);
            var mapping = _mapper.Map<Employee, EmployeeSM>(employee);
            return mapping;
        }

        public async Task AddEmployeeAsync(EmployeeSM empNew)
        {
            try
            {
                _uow.BeginTransaction();

                var emp = _mapper.Map<Employee>(empNew);
                await _uow.GetRepository<Employee>().AddItemAsync(emp);

                _uow.Commit();
            }
            catch
            {
                await _uow.RollbackAsync();
            }
        }

        public async Task UpdateEmployeeAsync(EmployeeSM employee)
        {
            try
            {
                _uow.BeginTransaction();

                var empUpdate = _mapper.Map<Employee>(employee);
                await _uow.GetRepository<Employee>().UpdateAsync(empUpdate);

                _uow.Commit();
            }
            catch (Exception)
            {
                _uow.Rollback();
            }
        }
    }
}
