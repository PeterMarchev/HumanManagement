using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class JobVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Job name")]
        public virtual string Name { get; set; }
        [DisplayName("Base salary")]
        public virtual decimal BaseSalary { get; set; }
        public virtual ScheduleVM Schedule { get; set; }
    }
}
