using AutoMapper;
using HumanManagement.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;


        public EmployeeController(IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        public IActionResult EmployeeListing()
        {
            var employees = _employeeService.GetAllEmployees();
            List<EmployeeVM> employee = _mapper.Map<List<EmployeeSM>, List<EmployeeVM>>(employees);
            return View(employee);
        }
    }
}
