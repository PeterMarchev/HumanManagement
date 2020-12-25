//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Threading.Tasks;

//namespace HumanManagement.Models.ViewModels
//{
//    public class EmployeeVM
//    {
//        public virtual Guid Id { get; set; }
//        public virtual Guid HRid { get; set; }
//        [DisplayName("First name")]
//        public virtual string FirstName { get; set; }
//        [DisplayName("Last name")]
//        public virtual string LastName { get; set; }
//        [DisplayName("Email")]
//        public virtual string Email { get; set; }
//        [DisplayName("Phone")]
//        public virtual string PhoneNumber { get; set; }
//        [DisplayName("Nationality")]
//        public virtual string Nationality { get; set; }
//        [DisplayName("Gender")]
//        public virtual string Gender { get; set; }
//        [DisplayName("Address")]
//        public virtual string StreetAddress { get; set; }
//        [DisplayName("Hired on")]
//        public virtual DateTime HireDate { get; set; }
//        [DisplayName("Fired on")]
//        public virtual DateTime? TerminationDate { get; set; }
//        [DisplayName("Works as")]
//        public virtual JobVM Job { get; set; }
//        [DisplayName("Department name")]
//        public virtual DepartmentVM Department { get; set; }
//        [DisplayName("Emergency contacts")]
//        public virtual ICollection<EmergencyContactsVM> EmergencyContacts { get; set; }
//        [DisplayName("Manager")]
//        public virtual EmployeeVM Manager { get; set; }
//        [DisplayName("Salary")]
//        public virtual SalaryVM Salary { get; set; }
//        //public virtual ICollection<DepartmentManagersVM> DepartmentManagers { get; set; }
//        [DisplayName("Name")]
//        public string FullName
//        {
//            get
//            {
//                return FirstName + " " + LastName;
//            }
//        }

//        [DisplayName("Managed by")]
//        public string ManagerFN
//        {
//            get
//            {
//                return Manager.FirstName + " " + Manager.LastName;
//            }
//        }
//    }
//}
