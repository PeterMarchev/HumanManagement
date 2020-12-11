using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Job
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal BaseSalary { get; set; }
        public virtual Guid ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
