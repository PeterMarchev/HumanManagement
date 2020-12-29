using Services.ServiceModels;
using System;

namespace Services.ServiceModels
{
    public partial class AttendanceSM
    {
        public virtual Guid Id { get; set; }
        public virtual TimeSpan ClockIn { get; set; }
        public virtual TimeSpan? ClockOut { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Guid EmployeeId { get; set; }
        public virtual EmployeeSM Employee { get; set; }
    }
}
