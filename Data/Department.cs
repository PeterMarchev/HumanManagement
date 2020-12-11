using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Department
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Guid LocationId { get; set; }
        public virtual Guid CompanyId { get; set; }
        public virtual Location Location { get; set; }
        public virtual IList<Employee> Employees { get; set; }
        public virtual Company Company { get; set; }
        public virtual DepartmentManager DepartmentManagers { get; set; }
    }
}
