using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Salary
    {
        public virtual Guid Id { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime EffectiveDate { get; set; }
        public virtual Guid PeriodicityId { get; set; }
        public virtual Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Periodicity Periodicity { get; set; }

    }
}
