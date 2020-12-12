using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    class ScheduleMapping : ClassMap<Schedule>
    {
        public ScheduleMapping()
        {
            Table("Schedule");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Type)
               .Column("type")
               .Not.Nullable();

            Map(x => x.Hours)
                .Column("hours")
                .ReadOnly()
                .Not.Nullable();
        }
    }
}
