using System;
using System.Collections.Generic;

namespace Services.ServiceModels
{
    public partial class EmployeeSM
    {
        public virtual Guid Id { get; set; }
        public virtual Guid HRid { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Nationality { get; set; }
        public virtual string Gender { get; set; }
        public virtual SalarySM Salary { get; set; }
        public virtual string StreetAddress { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual DateTime? TerminationDate { get; set; }
        public virtual Guid? JobId { get; set; }
        public virtual Guid? DepartmentId { get; set; }
        public virtual Guid? ManagerId { get; set; }
        public virtual JobSM Job { get; set; }
        public virtual DepartmentSM Department { get; set; }
        public virtual ICollection<EmergencyContactsSM> EmergencyContacts { get; set; }
        public virtual EmployeeSM Manager { get; set; }
        public virtual ICollection<DepartmentManagerSM> DepartmentManagers { get; set; }
    }
}
