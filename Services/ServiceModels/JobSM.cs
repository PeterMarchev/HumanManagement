using System;

namespace Services
{
    public partial class JobSM
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal BaseSalary { get; set; }
        public virtual Guid ScheduleId { get; set; }
        public virtual ScheduleSM Schedule { get; set; }
    }
}
