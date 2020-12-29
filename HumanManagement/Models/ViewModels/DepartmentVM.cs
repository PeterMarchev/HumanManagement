using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class DepartmentVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Department name")]
        public virtual string Name { get; set; }
        [DisplayName("Deparment Location")]
        public virtual LocationVM Location { get; set; }
        [DisplayName("Company")]
        public virtual CompanyVM Company { get; set; }
        public virtual IList<EmployeeVM> Employees { get; set; }
        public virtual DepartmentManagerVM DepartmentManagers { get; set; }
    }
}
