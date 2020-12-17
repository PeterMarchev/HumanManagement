using System;

namespace Services
{
    public partial class DepartmentManagerSM
    {
        public virtual Guid EmployeeId { get; set; }
        public virtual Guid DepartmentId { get; set; }
        public virtual EmployeeSM Employee { get; set; }
        public virtual DepartmentSM Department { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DepartmentManagerSM manager &&
                   EmployeeId.Equals(manager.EmployeeId) &&
                   DepartmentId.Equals(manager.DepartmentId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EmployeeId, DepartmentId);
        }
    }
}
