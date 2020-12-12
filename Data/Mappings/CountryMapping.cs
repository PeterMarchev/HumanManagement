using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class CountryMapping : ClassMap<Country>
    {
        public CountryMapping()
        {
            Table("Country");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Name)
                .Column("name")
                .Not.Nullable();

            Map(x => x.Currency)
                .Column("currency")
                .Not.Nullable();

            HasMany(x => x.Locations)
                .KeyColumn("company_id")
                .Inverse()
                .Fetch.Join();

        }
    }
}
