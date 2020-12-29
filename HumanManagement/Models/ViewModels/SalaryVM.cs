using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class SalaryVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Salary amount")]
        public virtual decimal Amount { get; set; }
        [DisplayName("Periodicity")]
        public virtual Guid PeriodicityId { get; set; }
        [DisplayName("Effective date")]
        public virtual DateTime EffectiveDate { get; set; }
        [DisplayName("Employee")]
        public virtual Guid EmployeeId { get; set; }
    }
}
