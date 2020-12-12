using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    class SalaryMapping : ClassMap<Salary>
    {
        public SalaryMapping()
        {
            Table("Salary");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Amount)
                .Column("amount")
                .Not.Nullable();

            Map(x => x.EffectiveDate)
                .Column("effective_date")
                .Not.Nullable();

            References(x => x.Employee)
                .Column("employee_id")
                .Not.Nullable()
                .ReadOnly()
                .Fetch.Join();

            Map(x => x.EmployeeId)
                .Column("employee_id")
                .Not.Nullable();

            References(x => x.Periodicity)
                .Column("periodicity_id")
                .Not.Nullable()
                .ReadOnly()
                .Fetch.Join();

            Map(x => x.PeriodicityId)
                .Column("periodicity_id")
                .Not.Nullable();
        }
    }
}
