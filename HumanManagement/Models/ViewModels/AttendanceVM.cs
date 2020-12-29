using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class AttendanceVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Signed in at")]
        public virtual TimeSpan ClockIn { get; set; }
        [DisplayName("Signed out at")]
        public virtual TimeSpan? ClockOut { get; set; }
        [DisplayName("Date")]
        public virtual DateTime Date { get; set; }
        public virtual EmployeeVM Employee { get; set; }
    }
}
