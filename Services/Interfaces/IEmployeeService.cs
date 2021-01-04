using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeSM> GetAllEmployees();
        Task<EmployeeSM> GetEmployeeByIdAsync(object id);
        Task UpdateEmployeeAsync(EmployeeSM employee);
        Task AddEmployeeAsync(EmployeeSM empNew);
    }
}
