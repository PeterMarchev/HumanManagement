using System;

namespace Services
{
    public partial class LocationSM
    {
        public virtual Guid Id { get; set; }
        public virtual string AddressOne { get; set; }
        public virtual string AddressTwo { get; set; }
        public virtual string Town { get; set; }
        public virtual Guid CountryId { get; set; }
        public virtual CountrySM Country { get; set; }
    }
}
