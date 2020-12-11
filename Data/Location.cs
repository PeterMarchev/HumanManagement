using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Location
    {
        public virtual Guid Id { get; set; }
        public virtual string AddressOne { get; set; }
        public virtual string AddressTwo { get; set; }
        public virtual string Town { get; set; }
        public virtual Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
