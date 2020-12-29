using System;

namespace Services.ServiceModels
{
    public partial class SalaryHistorySM
    {
        public virtual decimal Amount { get; set; }
        public virtual Guid PeriodicityId { get; set; }
        public virtual DateTime EffectiveDate { get; set; }
        public virtual DateTime ChangedOn { get; set; }
        public virtual Guid SalaryId { get; set; }
        public virtual SalarySM Salary { get; set; }
    }
}
