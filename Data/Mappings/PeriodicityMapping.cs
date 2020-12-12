using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class PeriodicityMapping : ClassMap<Periodicity>
    {
        public PeriodicityMapping()
        {
            Table("periodicity");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Type)
                .Column("type")
                .Not.Nullable();

            HasMany(x => x.Salaries);
        }
    }
}
