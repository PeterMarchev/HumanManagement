using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public partial class Company
    {
        public virtual Guid Id { get; set; }
        public virtual string CIN { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Department> Departments { get; set; }
    }
}
