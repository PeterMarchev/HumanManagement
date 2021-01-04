using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.InputModels
{
    public class CountryCreateIM
    {
        [DisplayName("Country name")]
        public virtual string Name { get; set; }
        public virtual string Currency { get; set; }
    }
}
