using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class EmployeeMapping : ClassMap<Employee>
    {
        public EmployeeMapping()
        {
            Table("Employee");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.FirstName)
                .Column("first_name")
                .Not.Nullable();

            Map(x => x.LastName)
                .Column("last_name")
                .Not.Nullable();

            Map(x => x.Email)
                .Column("email")
                .Not.Nullable()
                .Unique();

            Map(x => x.Gender)
                .Column("gender")
                .Nullable();

            Map(x => x.PhoneNumber)
                .Column("phone_number")
                .Nullable()
                .Unique();

            Map(x => x.HireDate)
                .Column("hire_date")
                .Nullable();

            Map(x => x.StreetAddress)
                .Column("street_address")
                .Nullable();

            Map(x => x.TerminationDate)
                .Column("termination_date")
                .Nullable();

            Map(x => x.Nationality)
                .Column("nationality")
                .Nullable();

            References(x => x.Job)
                .Column("job_id")
                .Nullable()
                .ReadOnly()
                .Fetch.Join();

            Map(x => x.JobId)
                .Column("job_id")
                .Nullable();

            References(x => x.Department)
                .Column("department_id")
                .Nullable()
                .ReadOnly()
                .Fetch.Join();

            Map(x => x.DepartmentId)
                .Column("department_id")
                .Nullable();

            References(x => x.Manager)
                .Column("manager_id")
                .Nullable()
                .ReadOnly()
                .Fetch.Join();

            Map(x => x.ManagerId)
                .Column("manager_id")
                .Nullable();

            HasMany(x => x.EmergencyContacts);

            HasOne(x => x.Salary)
                .PropertyRef(x => x.Employee);
        }
    }
}
