using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Employee
    {
        public virtual Guid Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Gender { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Nationality { get; set; }
        public virtual string StreetAddress { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual DateTime? TerminationDate { get; set; }
        public virtual Guid JobId { get; set; }
        public virtual Guid? ManagerId { get; set; }
        public virtual Guid DepartmentId { get; set; }
        public virtual Job Job { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual Salary Salary { get; set; }
        public virtual ICollection<DepartmentManager> DepartmentManagers { get; set; }

    }
}
