using System;
using System.Collections.Generic;

namespace Services
{
    public partial class CountrySM
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Currency { get; set; }
        public virtual IList<LocationSM> Locations { get; set; }
    }
}
