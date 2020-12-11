using System;
using System.Collections.Generic;
using System.Text;

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
