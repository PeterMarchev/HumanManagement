using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Schedule
    {
        public virtual Guid Id { get; set; }
        public virtual string Type { get; set; }
        public virtual int Hours { get; set; }
        public virtual IList<Job> Jobs { get; set; }
    }
}
