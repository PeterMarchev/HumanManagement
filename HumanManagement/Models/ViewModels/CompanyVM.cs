using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class CompanyVM
    {
        public virtual Guid Id { get; set; }
        public virtual string CIN { get; set; }
        [DisplayName("Company name")]
        public virtual string Name { get; set; }
        public virtual IList<DepartmentVM> Departments { get; set; }
    }
}
