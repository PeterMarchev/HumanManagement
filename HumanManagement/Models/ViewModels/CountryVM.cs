using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class CountryVM
    {
        public virtual Guid Id { get; set; }
        [DisplayName("Country name")]
        public virtual string Name { get; set; }
        public virtual string Currency { get; set; }
        public virtual IList<LocationVM> Locations { get; set; }
    }
}
