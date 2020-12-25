using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class DepartmentManagerMapping : ClassMap<DepartmentManager>
    {
        public DepartmentManagerMapping()
        {
            Table("Department_manager");

            CompositeId()
              .KeyProperty(x => x.EmployeeId, "employee_id")
              .KeyProperty(x => x.DepartmentId, "department_id");

            References(x => x.Employee)
                .Column("employee_id")
                .Not.Nullable()
                .Fetch.Join()
                .ReadOnly();

            References(x => x.Department)
                .Column("department_id")
                .Not.Nullable()
                .Fetch.Join()
                .ReadOnly();
        }
    }
}
