using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Models.ViewModels
{
    public class RoleVM
    {
        public string Id { get; set; }
        [DisplayName("Role name")]
        public string Name { get; set; }

        public IEnumerable<UserVM> Users { get; set; }
    }
}
