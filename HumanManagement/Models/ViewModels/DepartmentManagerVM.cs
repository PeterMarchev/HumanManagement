using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class DepartmentManagerVM
    {
        public virtual DepartmentVM Department { get; set; }
        public virtual EmployeeVM Employee { get; set; }

    }
}
