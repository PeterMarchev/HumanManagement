using System;
using System.Collections.Generic;

namespace Services.ServiceModels
{
    public partial class PeriodicitySM
    {
        public virtual Guid Id { get; set; }
        public virtual string Type { get; set; }
        public virtual DateTime SetOn { get; set; }
        public virtual IList<SalarySM> Salaries { get; set; }

    }
}
