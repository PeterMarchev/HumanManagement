using System;
using System.Collections.Generic;

namespace Services.ServiceModels
{
    public partial class CompanySM
    {
        public virtual Guid Id { get; set; }
        public virtual string CIN { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<DepartmentSM> Departments { get; set; }
    }
}
