using System;
using System.Collections.Generic;

namespace Services
{
    public partial class ScheduleSM
    {
        public virtual Guid Id { get; set; }
        public virtual string Type { get; set; }
        public virtual int Hours { get; set; }
        public virtual IList<JobSM> Jobs { get; set; }
    }
}
