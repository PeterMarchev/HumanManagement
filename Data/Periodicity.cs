﻿using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Periodicity
    {
        public virtual Guid Id { get; set; }
        public virtual string Type { get; set; }
        public virtual DateTime SetOn { get; set; }
        public virtual IList<Salary> Salaries { get; set; }

    }
}
