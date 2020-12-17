using System;

namespace Services
{
    public partial class EmergencyContactsSM
    {
        public virtual Guid Id { get; set; }
        public virtual Guid EmployeeId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string EmergPhone { get; set; }
        public virtual string EmergAddress { get; set; }
        public virtual EmployeeSM Employee { get; set; }
    }
}
