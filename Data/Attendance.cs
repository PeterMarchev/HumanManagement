using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Attendance
    {
        public virtual Guid Id { get; set; }
        public virtual TimeSpan ClockIn { get; set; }
        public virtual TimeSpan? ClockOut { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }           
}
