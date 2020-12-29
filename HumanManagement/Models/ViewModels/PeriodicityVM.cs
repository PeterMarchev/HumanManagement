using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class PeriodicityVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Periodicity type")]
        public virtual string Type { get; set; }
        public virtual IList<SalaryVM> Salaries { get; set; }
    }
}
