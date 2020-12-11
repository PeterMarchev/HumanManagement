using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class DepartmentManager
    {
        public virtual Guid EmployeeId { get; set; }
        public virtual Guid DepartmentId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DepartmentManager manager &&
                   EmployeeId.Equals(manager.EmployeeId) &&
                   DepartmentId.Equals(manager.DepartmentId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EmployeeId, DepartmentId);
        }
    }
}
