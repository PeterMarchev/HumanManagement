using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class CountryMapping : ClassMap<Country>
    {
        public CountryMapping()
        {
            Table("Country");

            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Name)
                .Column("name")
                .Not.Nullable();

            Map(x => x.Currency)
                .Column("currency")
                .Not.Nullable();

            HasMany(x => x.Locations)
                .KeyColumn("country_id")
                .Inverse()
                .Fetch.Join();
        }
    }
}
