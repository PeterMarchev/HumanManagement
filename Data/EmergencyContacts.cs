using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class EmergencyContacts
    {
        public virtual Guid EmployeeId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string EmergPhone { get; set; }
        public virtual string EmergAddress { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
