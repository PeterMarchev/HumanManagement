using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeSM> GetAllEmployees();
    }
}
