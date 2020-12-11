using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class SalaryHistory
    {
        public virtual decimal Amount { get; set; }
        public virtual Guid PeriodicityId { get; set; }
        public virtual DateTime EffectiveDate { get; set; }
        public virtual DateTime ChangedOn { get; set; }
        public virtual Guid SalaryId { get; set; }
        public virtual Salary Salary { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SalaryHistory history &&
                   EqualityComparer<Salary>.Default.Equals(Salary, history.Salary);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Salary);
        }
    }
}
