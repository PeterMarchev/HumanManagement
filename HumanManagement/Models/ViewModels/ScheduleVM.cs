using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class ScheduleVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Employment")]
        public virtual string Type { get; set; }
        public virtual int Hours { get; set; }
        public virtual IList<JobVM> Jobs { get; set; }
    }
}
