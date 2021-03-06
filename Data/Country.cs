﻿using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Country
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Currency { get; set; }
        public virtual IList<Location> Locations { get; set; }
    }
}
