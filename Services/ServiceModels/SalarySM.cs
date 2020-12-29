using Services.ServiceModels;
using System;


namespace Services.ServiceModels
{
    public partial class SalarySM
    {
        public virtual Guid Id { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime EffectiveDate { get; set; }
        public virtual Guid PeriodicityId { get; set; }
        public virtual Guid EmployeeId { get; set; }
        public virtual EmployeeSM Employee { get; set; }
        public virtual PeriodicitySM Periodicity { get; set; }

    }
}
