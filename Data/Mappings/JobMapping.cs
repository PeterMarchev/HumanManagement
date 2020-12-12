using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    class JobMapping : ClassMap<Job>
    {
        public JobMapping()
        {
            Table("Job");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Name)
                .Column("name")
                .Not.Nullable();

            Map(x => x.BaseSalary)
                .Column("base_salary")
                .Not.Nullable();

            References(x => x.Schedule)
                .Column("schedule_id")
                .Not.Nullable()
                .ReadOnly();

            Map(x => x.ScheduleId)
                .Column("schedule_id")
                .Not.Nullable();
        }
    }
}
