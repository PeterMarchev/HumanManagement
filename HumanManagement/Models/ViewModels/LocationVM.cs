using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class LocationVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Address")]
        public virtual string AddressLineOne { get; set; }
        [DisplayName("Additional address")]
        public virtual string AddressLineTwo { get; set; }
        public virtual string Town { get; set; }
        public virtual CountryVM Country { get; set; }
    }
}
