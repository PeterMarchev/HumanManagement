using Services.ServiceModels;
using System;
using System.Collections.Generic;

namespace Services.ServiceModels
{
    public partial class DepartmentSM
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Guid LocationId { get; set; }
        public virtual Guid CompanyId { get; set; }
        public virtual LocationSM Location { get; set; }
        public virtual IList<EmployeeSM> Employees { get; set; }
        public virtual CompanySM Company { get; set; }
        public virtual DepartmentManagerSM DepartmentManagers { get; set; }
    }
}
