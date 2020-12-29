using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class EmergencyContactsVM
    {

        public virtual Guid EmployeeId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        [DisplayName("Emergency phone")]
        public virtual string EmergencyPhone { get; set; }
        [DisplayName("Emergency address")]
        public virtual string EmergencyAddress { get; set; }
        [DisplayName("Emergency contact name")]
        public virtual string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
